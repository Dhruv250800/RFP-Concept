internal class Program
{
    static void Main(string[] args)
    {
        /* Solid Principle 
        (1) SRP (Single Responsibility Principle) */
        Vehicle objVehicle = new Vehicle();
        objVehicle.GetVehicleColor();

        Email objEmail = new Email();
        objEmail.EmailSend();


        // (2) OCP (Open Close Principle)
        AllMobileInfo mainObj = new AllMobileInfo();

        RedmiDerived redmi = new RedmiDerived();
        IphoneDerived iphone = new IphoneDerived();

        mainObj.AllInfo(redmi);
        mainObj.AllInfo(iphone);



        // (3) LSP (Liskov Substitution Principle)
        Employeee empObj = new Employeee();
        PermanentEmployee PeObj = new PermanentEmployee();

        empObj.CalculateSalary();
        empObj.CalculateBonus();

        PeObj.CalculateBonus();
        PeObj.CalculateSalary();




        // (4) ISP (Interface Segregation Principle)
        DerivedFlyingClass IspObj = new DerivedFlyingClass();
        IspObj.BirdFly();
        IspObj.DogRun();





        // --------------- SEARIALIZATION AND DESERIALIZATION ----------------
        //  Console.WriteLine("Serilization applied...");
        //  SerilizationDeserilizationClass obj = new SerilizationDeserilizationClass();
        //            obj.SerilizationMthod();
        //          Console.WriteLine("------------------------");
        //        obj.DeseRilization();


        // NewtonSoft.json :-
        //   Bike obj = new Bike { Qnt = 4, Name = "HayaBusa" };
        //  Console.WriteLine("Original Data: " + obj.Qnt + ", " + obj.Name);

        // string jsonFormatResult = JsonConvert.SerializeObject(obj);
        //        Console.WriteLine("Json Object: " + jsonFormatResult);

        // Bike deserializedObj = JsonConvert.DeserializeObject<Bike>(jsonFormatResult);
        // Console.WriteLine(deserializedObj.Qnt + deserializedObj.Name);











        //LAMBDA EXPRESSION :-
        // Type 01 ->  ------------------  EXPRESSION LAMBDA -----------------------
        //  Console.WriteLine("Enter a number for calculate the square");
        // int num = Convert.ToInt16(Console.ReadLine());

        // int result = ExpressionLambda.sqr(num);
        // Console.WriteLine("Square of " + num + " is :- " + result);


        // Type 02 ->  ------------------  STATEMENT LAMBDA ------------------
        //StatementLambda.Greet("Karan");





        // ----------------- ENUM ----------------------
        // EnumDemo obj = new EnumDemo();
        // obj.EnumMethod();








        // .Net Reflection :-

        // Type classType = typeof(Person);
        // Console.WriteLine( "Type information of Person Class :- " +  classType);

        //   Console.WriteLine("----------------------");

        //  Console.WriteLine("Creating the object");
        //  Person obj = new Person("Dhruv" , 22);

        //  Console.WriteLine("----------------------");

        //  Console.WriteLine("Getting Properties of Person Class :-");
        //  PropertyInfo[] myProperties = classType.GetProperties();
        //  foreach(PropertyInfo data in myProperties)
        // {
        //     Console.WriteLine(data);
        //  }

        //  Console.WriteLine("----------------------");

        //  Console.WriteLine("Getting Methods of Person class :-");
        //  MethodInfo[] myMethods = classType.GetMethods();
        //  foreach(MethodInfo data in myMethods)
        //  {
        //    Console.WriteLine(data);
        //   }












        // Exception Handling :-
        // ExceptionHandlingDemo obj = new ExceptionHandlingDemo();
        // obj.CheckDivision();








        // Generic Example :-
        //GenericsDemo objGeneric = new GenericsDemo();

        //Console.WriteLine("Enter first value :");
        // string str1 = Console.ReadLine();
        // Console.WriteLine("Enter Second value :");
        // string str2 = Console.ReadLine();

        // Console.WriteLine( "Before Swap  :" +  str1 + " , " + str2);

        //  objGeneric.SwapTowInput(ref str1, ref str2);
        //  Console.WriteLine( "After Swap  : " + str1 + " , " + str2);









        //Console.WriteLine("Welcome to Basics of .NET");
        //ArrayTopic obj1 = new ArrayTopic();
        // obj1.ArrMethod();

        //ArrayListDemo obj2 = new ArrayListDemo();
        //obj2.ArrayListMethod();

        //VarKeyWord obj3 = new VarKeyWord();
        //obj3.VarMethod();

        // Default constructor OR Parameterless Constructor
        // DefaultConstructor obj4 = new DefaultConstructor();
        // Console.ReadLine();


        // Parameterized constructor
        // ParameterizedConstructor obj5 = new ParameterizedConstructor(25, 08, "Dhruv");
        // Console.ReadLine();

        // ------------------------- INHERITANCE -------------------------------------
        // Single Level Inheritance
        //ChildClass obj4 = new ChildClass();
        //obj4.DisplayEmpDetail();

        //MULTI LEVEL INHERITANCE
        // Child obj5 = new Child();
        //obj5.DisplayDetail();
        //obj5.DisplayEmpDetailOnParent();


        // Multiple Inheritance
        //Smartphone obj6 = new Smartphone();
        //obj6.GetPhoneDetail();
        //obj6.GetCameraDetail();


        //----------------------------------- POLYMORPHISM --------------------------------
        //MethodOverloading obj7 = new MethodOverloading();
        //obj7.Display("Dhruv", 3000);
        //obj7.Display(100, 200);


        //Child obj8 = new Child();
        //obj8.Display(5, 5);



        //------------------------ ENCAPSULATION ---------------------------------------
        // Encapsulation obj9 = new Encapsulation();
        //obj9.Get();

        // EncapsulationGetterSetterProperty obj10 = new EncapsulationGetterSetterProperty();
        //obj10.myProperty



        //--------------------- ABSTRACTION -----------------------------------------
        // Animal objDog = new Dog();
        // objDog.Sound();

        // Animal objCat = new Cat();
        // objCat.Sound();




        // ------------------------- LIST----------------------------------
        /*        ListProgram obj1 = new ListProgram()
                {
                    name = "karan",
                    age = 23,
                    salary = 1000
                };

                ListProgram obj2 = new ListProgram()
                {
                    name = "Manoj",
                    age = 25,
                    salary = 5000
                };

                List <ListProgram> list = new List <ListProgram> ();
                list.Add(obj1);
                list.Add(obj2);

                foreach(var item in list)
                {
                    Console.WriteLine("Name: " + item.name + " , " + " Age: " + item.age + " , " + "salary: " + item.salary);
                }

                */



        // -------------------- GENERIC ------------------------------------
        // GenericClass obj = new GenericClass();
        // obj.CheckEqual("Karan" , "Karan");



        //------------------ LINKED LIST ------------------------------------
        //  LinkedListSubClass objList = new LinkedListSubClass();
        //  objList.AddNewData(100);
        //  objList.AddNewData(200);
        //  objList.AddNewData(300);
        //  objList.AddNewData(400);
    }
}