﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace WinTail
{
    class FileValidatorActor : UntypedActor
    {

        private readonly IActorRef _consoleWriterActor;
        //private readonly IActorRef _tailCoordinatorActor;

        public FileValidatorActor(IActorRef consoleWriterActor)//,
           // IActorRef tailCoordinatorActor)
        {
            _consoleWriterActor = consoleWriterActor;
            //_tailCoordinatorActor = tailCoordinatorActor;
        }


        protected override void OnReceive(object message)
        {
            var msg = message as string;
            if (string.IsNullOrEmpty(msg))
            {
                _consoleWriterActor.Tell(new Messages.NullInputError("Input was blank. Please try again."));
                Sender.Tell(new Messages.ContinueProcessing());
            }
            else
            {
                var valid = IsFileUri(msg);
                if (valid)
                {
                    _consoleWriterActor.Tell(new Messages.InputSuccess(string.Format("Starting processing for {0}", msg)));

                    //_tailCoordinatorActor.Tell(new TailCoordinatorActor.StartTail(msg, _consoleWriterActor));
                    Context.ActorSelection("akka://MyActorSystem/user/tailCoordinatorActor").Tell(
                        new TailCoordinatorActor.StartTail(msg, _consoleWriterActor));

                }
                else
                {
                    _consoleWriterActor.Tell(new Messages.ValidationError(string.Format("{0} is not an existing URI on disk.", msg)));

                    Sender.Tell(new Messages.ContinueProcessing());
                }
            }


        }

        private static bool IsFileUri(string path)
        {
            return File.Exists(path);
        }

    }
}
