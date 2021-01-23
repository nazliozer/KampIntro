using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //IhtiyacKrediManager= IKrediManager 
            IKrediManager taşıtKrediManager = new TaşıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerservice = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> {  new FileLoggerService(), new SmsLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager() , loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, taşıtKrediManager};
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
