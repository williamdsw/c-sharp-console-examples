
namespace c_sharp_console_examples
{
    class Program
    {
        //-----------------------------------------------------------------------//
        // MAIN
        
        static void Main (string[] args)
        {
            TestAdvanced ();
            TestBasic ();
            TestClasses ();
            TestLists ();
            TestDatabase ();
            TestUtils ();
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        private static void TestAdvanced ()
        {
            //DelegateExample delegateExample = new DelegateExample ();
            //EventExample eventExample = new EventExample ();
            //LambdaExample lambdaExample = new LambdaExample ();
            //LINQExample linqExample = new LINQExample ();
        }

        private static void TestBasic ()
        {
            //ArrayParameters arrayParameters = new ArrayParameters ();
            //BasicOperators basicOperators = new BasicOperators ();
            //Casting casting = new Casting ();
            //NullableTypes nullableTypes = new NullableTypes ();
            //ParametersRefOut parametersRefOut = new ParametersRefOut ();
            //RandomExamples randomExamples = new RandomExamples ();
            //UsingExamples usingExamples = new UsingExamples ();
            //VariableTypes variableTypes = new VariableTypes ();
        }

        private static void TestClasses ()
        {
            //AnonymousClasses anonymousClasses = new AnonymousClasses ();
            //ClassUse classUse = new ClassUse ();
        }

        private static void TestLists ()
        {
            //DictionaryExample dictionaryExample = new DictionaryExample ();
            //HashSetExample hashSetExample = new HashSetExample ();
            //LinkedListExample linkedListExample = new LinkedListExample ();
            //ListExample listExample = new ListExample ();
            //QueueExample queueExample = new QueueExample ();
            //SortedListExample sortedListExample = new SortedListExample ();
            //StackExample stackExample = new StackExample ();
        }

        private static void TestDatabase ()
        {
            //DatabaseConnection databaseConnection = new DatabaseConnection ();
            //databaseConnection.ShowConnectionProperties ();
            //DeleteCommand deleteCommand = new DeleteCommand ();
            //InsertCommand insertCommand = new InsertCommand ();
            //SelectCommand selectCommand = new SelectCommand ();
            //UpdateCommand updateCommand = new UpdateCommand ();
        }

        private static void TestUtils ()
        {
            //ScanDevicesAdvanced scanDevicesAdvanced = new ScanDevicesAdvanced ();
            //ScanDevicesSimple scanDevicesSimple = new ScanDevicesSimple ();
            //SendEmailExample sendEmailExample = new SendEmailExample ();
            XMLExample xmlExample = new XMLExample ();
        }
    }
}
