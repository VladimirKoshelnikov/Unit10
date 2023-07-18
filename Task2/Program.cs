using System;
using System.IO;

namespace Task2{
    class Program{
        
        class Subtask1{
            public interface IWhatsapp{
                public void SendMessage(string message);
            }

            public interface IViber{
                public void SendMessage(string message);
            }

            public class NewMessenger: IViber, IWhatsapp{
                void IViber.SendMessage(string message){
                    Console.WriteLine("{0}: {1}", "Viber", message);
                }
                void IWhatsapp.SendMessage(string message){
                    Console.WriteLine("{0}: {1}", "WhatsApp", message);
                }
            }
        
            public Subtask1(){
                NewMessenger newMessenger = new NewMessenger();

                ((IWhatsapp)newMessenger).SendMessage("Hello Word");
                ((IViber)newMessenger).SendMessage("Hello Word");

                Console.ReadLine();
            }
        }

        class Subtask2{
            public interface IWriter{
                public void Write(string message);
            }

            public class NewWriter: IWriter{
                public void IWriter.Write(string message){
                    throw NotImplementedException;
                }
            }
        
            public Subtask2(){
                NewWriter writer = new NewWriter();
                ((IWriter) writer).Write("Da");
            }
        }

        class Subtask3{
            public interface IWorker{
                public void Build();
            }

            public class NewWorker: IWorker{
                public void Build(){
                    throw NotImplementedException;
                }
            }
        
            public Subtask3(){
                NewWorker worker = new NewWorker();
                ((IWorker) worker).Build();
            }
        }

        static void Main(){
            Subtask1 st1 = new Subtask1();
        }
    }
}