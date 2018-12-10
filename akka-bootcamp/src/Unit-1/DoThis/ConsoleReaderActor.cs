using System;
using Akka.Actor;

namespace WinTail
{
    /// <summary>
    /// Actor responsible for reading FROM the console. 
    /// Also responsible for calling <see cref="ActorSystem.Terminate"/>.
    /// </summary>
    public class ConsoleReaderActor : UntypedActor
    {
        public const string ExitCommand = "exit";
        public const string StartCommand = "start";
        //private IActorRef _validationActor;

        //public ConsoleReaderActor(IActorRef validationActor)
        //{
        //    _validationActor = validationActor;
        //}

        protected override void OnReceive(object message)
        {
            //var read = Console.ReadLine();
            if (message.Equals(StartCommand))
            {
                // shut down the system (acquire handle to system via
                // this actors context)
                //Context.System.Terminate();
                //return;
                DoPrintInstructions();
            }
            //else if (message is Messages.InputError)
            //{
            //    _consoleWriterActor.Tell(message as Messages.InputError);
            //}

            GetAndValidateInput();

            // send input to the console writer to process and print
            // YOU NEED TO FILL IN HERE
            //_consoleWriterActor.Tell(read);

            // continue reading messages from the console
            // YOU NEED TO FILL IN HERE
            //Self.Tell("continue");


        }


        #region Internal methods
        private void DoPrintInstructions()
        {
            //Console.WriteLine("Write whatever you want into the console!");
            //Console.WriteLine("Some entries will pass validationm, and some won't... \n\n");
            //Console.WriteLine("Type 'exit' to quit this application anytime \n");
            Console.WriteLine("Please provide the URI of a log file on disk.\n");
        }

        private void GetAndValidateInput()
        {


            var message = Console.ReadLine();
            if (!string.IsNullOrEmpty(message) && String.Equals(message, ExitCommand, StringComparison.OrdinalIgnoreCase))
            {
                Context.System.Terminate();
                return;
                //Self.Tell(new Messages.NullInputError("No input received."));
            }
            Context.ActorSelection("akka://MyActorSystem/user/validationActor").Tell(message);
            //else if (String.Equals(message, ExitCommand, StringComparison.OrdinalIgnoreCase))
            //{
            //    Context.System.Terminate();
            //    return;
            //}
            //else
            //{
            //    var valid = IsValid(message);
            //    if (valid)
            //    {
            //        _consoleWriterActor.Tell(new Messages.InputSuccess("Thank you! Message is valid!"));
            //
            //        Self.Tell(new Messages.ContinueProcessing());
            //    }
            //    else
            //    {
            //        Self.Tell(new Messages.ValidationError("Invalid: input had odd number of characters."));
            //
            //    }
            //}

            //_validationActor.Tell(message);
        }


        //private static bool IsValid(string message)
        //{
        //    var valid = message.Length % 2 == 0;
        //    return valid;
        //}

        #endregion
    

    }
}