namespace GSMDemo
{

    using System;

    class GSMTest
    {
        static void Main()
        {
            GSM[] phones = new GSM[4];
            phones[0] = new GSM("Galaxy", "Samsung");
            phones[1] = new GSM("Desire", "HTC", 101.23m);
            phones[2] = new GSM("Vibe", "Lenovo", 99.67m, "Some Owner");
            phones[3] = new GSM("P9", "Huawei", 103.12m, "Another Owner", new Battery("Some Battery Model"), new Display(5.4f, 16000000));

            foreach (GSM phone in phones)
            {
                Console.WriteLine(phone.Information());
            }

            Console.WriteLine(new string('=', 21));
            Console.WriteLine(GSM.Iphone4S.Information());
            Console.WriteLine(new string('=', 21));

            GSM myPhone = new GSM("A536", "Lenovo", 100, "I'm the owner!!!", new Battery("Some Battery Model"), new Display(5, 16000000));
            myPhone.AddCall(new Call(DateTime.Now, DateTime.Now, "+359(2)3434344", 328));
            myPhone.AddCall(new Call(DateTime.Now, DateTime.Now, "+359(88)3333333", 234));
            myPhone.AddCall(new Call(DateTime.Now, DateTime.Now, "+359(52)948391", 56));
            myPhone.AddCall(new Call(DateTime.Now, DateTime.Now, "+359(89)993913", 12));
            myPhone.ShowCallHistory();
            Console.WriteLine(new string('=', 21));

            Console.WriteLine("Total calls price: {0:c2}", myPhone.CallsPrice(0.37m));
            Console.WriteLine(new string('=', 21));

            myPhone.DeleteCall(0);
            Console.WriteLine("Total calls price without longest call: {0:c2}", myPhone.CallsPrice(0.37m));
            Console.WriteLine(new string('=', 21));

            myPhone.ClearHistory();
            myPhone.ShowCallHistory();
        }
    }
}
