using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Choose any one of the following: \n 1. HelloWorld \n 2. TypeConversion \n 3. Constants \n " +
                "4. Operators \n 5. Loops \n 6. CallByReference&null \n 7. Arrays \n 8. Strings \n 9. Structure \n " +
                "10. Enum\n 11. Inheritance\n 12. Polymorphism\n 13. Interface\n" +
                " 14. PreProcessor\n 15. ErrorHandling\n 16. FileIO\n 17. Properties \n " +
                "18. Indexers\n 19. Delegates \n 20. Events\n 21. Generics\n 22. Unsafe\n 23. MultiThread");

            option = Convert.ToInt32(Console.ReadLine());
            switch (option)  //example for switch and nested switch 
            {
                case 1:
                    Console.WriteLine("Hello World!");
                    break;
                case 2:
                    typeConversion type = new typeConversion(); //example for encapsuation
                    type.typeCast();
                    break;
                case 3:
                    constants typeConst = new constants();
                    typeConst.constant();
                    break;
                case 4:
                    Console.WriteLine("Choose any one of the following:\n 1. arithmetic \n 2. relational \n 3. logical \n " +
                        "4. bitwise \n 5. assignment");
                    option = Convert.ToInt32(Console.ReadLine());
                    operators op = new operators();
                    switch (option)
                    {
                        case 1:
                            op.arithmeticOperators();
                            break;
                        case 2:
                            op.relationalOperators();
                            break;
                        case 3:
                            op.logicalOperators();
                            break;
                        case 4:
                            op.bitwiseOperators();
                            break;
                        case 5:
                            op.assignmentOperators();
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine("Choose any one of the following:\n 1. while \n 2. for \n 3. do-while");
                    option = Convert.ToInt32(Console.ReadLine());
                    loop loopType = new loop();
                    switch (option)
                    {
                        case 1:
                            loopType.whileLoop();
                            break;
                        case 2:
                            loopType.forLoop();
                            break;
                        case 3:
                            loopType.dowhileLoop();
                            break;
                    }
                    break;
                case 6:
                    callByRef c = new callByRef();
                    c.callByReference();
                    break;
                case 7:
                    arrays a = new arrays();
                    Console.WriteLine("Choose any one of the following:\n 1. SimpleArray \n 2. MultiDimensional Arrays \n 3. Jagged Array \n " +
                        "4. ArrayClass");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            a.simpleArrayExample();
                            break;
                        case 2:
                            a.multiDimensionalArra();
                            break;
                        case 3:
                            a.jaggedArray();
                            break;
                        case 4:
                            a.arrayClass();
                            break;
                    }
                    break;
                case 8:
                    strings s = new strings();
                    s.stringOperations();
                    break;
                case 9:
                    structures structure = new structures();
                    structure.structureExamples();
                    break;
                case 10:
                    enumEx enumeration = new enumEx();
                    enumeration.enumExamples();
                    break;
                case 11:
                    testInheritance i = new testInheritance();
                    i.inheritanceExample();
                    break;
                case 12:
                    Tester t = new Tester();
                    polymorphism p = new polymorphism();
                    Console.WriteLine("Choose any one of the following:\n 1. Function Overloading \n 2. Operator Overloading");
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            p.functionOverloading(); //polymorphism
                            break;
                        case 2:
                            t.OperatorOverloading();
                            break;
                    }

                    break;
                case 13:
                    interfaceExample iE = new interfaceExample();
                    iE.iExample();
                    break;
                case 14:
                    preprocessor pp = new preprocessor();
                    pp.preprocessorExample();
                    break;
                case 15:
                    errorHandling e = new errorHandling();
                    e.division(25, 0);
                    break;
                case 16:
                    filestreamEx f = new filestreamEx();
                    f.fileEx();
                    break;
                case 17:
                    properties prop = new properties();
                    prop.propertiesExample();
                    break;
                case 18:
                    indexers ind = new indexers();
                    ind.indexerExample();
                    break;
                case 19:
                    delegates d = new delegates();
                    d.delegateExample();
                    break;
                case 20:
                    events eve = new events();
                    eve.eventExamples();
                    break;
                case 21:
                    generics gen = new generics();
                    gen.genericExamples();
                    break;
                case 22:
                    unsafeCodes uc = new unsafeCodes();
                    uc.unsafeExample();
                    break;
                case 23:
                    multiThreading mt = new multiThreading();
                    mt.multiThreadingExamples();
                    break;
            }
        }
    }
}
