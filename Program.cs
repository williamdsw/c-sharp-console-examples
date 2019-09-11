
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
            TestFunctions ();
            TestUtils ();
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        private static void TestAdvanced ()
        {
            DelegateExample delegateExample = new DelegateExample ();
            EventExample eventExample = new EventExample ();
            LambdaExample lambdaExample = new LambdaExample ();
            LINQExample linqExample = new LINQExample ();
        }

        private static void TestBasic ()
        {
            ArrayParameters arrayParameters = new ArrayParameters ();
            BasicOperators basicOperators = new BasicOperators ();
            Casting casting = new Casting ();
            NullableTypes nullableTypes = new NullableTypes ();
            ParametersRefOut parametersRefOut = new ParametersRefOut ();
            RandomExamples randomExamples = new RandomExamples ();
            UsingExamples usingExamples = new UsingExamples ();
            VariableTypes variableTypes = new VariableTypes ();
            JaggedArray jaggedArray = new JaggedArray ();
            StructExample structExample = new StructExample ();
        }

        private static void TestClasses ()
        {
            AnonymousClassUse anonymousClassUse = new AnonymousClassUse ();
            ClassUse classUse = new ClassUse ();
            Shape circle = new Circle ();
            circle.Draw ();
            Shape rectangle = new Rectangle ();
            rectangle.Draw ();
            GenericClassUse genericClassUse = new GenericClassUse ();
            StaticConstructorUse staticConstructorUse = new StaticConstructorUse ();
            DestructorClass destructorClass = new DestructorClass ();
            IndexerUse indexerUse = new IndexerUse ();
            InterfaceUse interfaceUse = new InterfaceUse ();
            Car car = new Car ();
        }

        private static void TestLists ()
        {
            DictionaryExample dictionaryExample = new DictionaryExample ();
            HashSetExample hashSetExample = new HashSetExample ();
            LinkedListExample linkedListExample = new LinkedListExample ();
            ListExample listExample = new ListExample ();
            QueueExample queueExample = new QueueExample ();
            SortedListExample sortedListExample = new SortedListExample ();
            StackExample stackExample = new StackExample ();
        }

        private static void TestDatabase ()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection ();
            databaseConnection.ShowConnectionProperties ();
            DeleteCommand deleteCommand = new DeleteCommand ();
            InsertCommand insertCommand = new InsertCommand ();
            SelectCommand selectCommand = new SelectCommand ();
            UpdateCommand updateCommand = new UpdateCommand ();
        }

        private static void TestFunctions ()
        {
            GenericFunctionExample genericFunctionExample = new GenericFunctionExample ();
            RecursiveFunctionExample recursiveFunctionExample = new RecursiveFunctionExample ();
        }

        private static void TestUtils ()
        {
            ScanDevicesAdvanced scanDevicesAdvanced = new ScanDevicesAdvanced ();
            ScanDevicesSimple scanDevicesSimple = new ScanDevicesSimple ();
            SendEmailExample sendEmailExample = new SendEmailExample ();
            XMLExample xmlExample = new XMLExample ();
            ArrayProperties arrayProperties = new ArrayProperties ();
        }
    }
}