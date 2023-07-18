using System;
using System.IO;

namespace Task3{
    class Program{       
        class Subtask1{
            public class Message{
                string TextMessage;
                string Address;

            }

            public interface IWriter{
                void Write();
            }
        
            public interface IReader{
                void Read();
            }
            public interface IMailer{
                void SendMail(Message message);
            }

            class FileManager :IWriter, IReader, IMailer{
                void IWriter.Write(){
                    throw new NotImplementedException();
                }
                void IReader.Read(){
                    throw  new NotImplementedException();
                }
        
                void IMailer.SendMail(Message message){
                    throw  new NotImplementedException();
                }
            }
        }
        
        class Subtask2{
            public interface ICreatable 
            {
                void Create();
            }

            public interface IDeletable 
            {
                void Delete();
            }

            public interface IUpdatable 
            {
                void Update();
            }


            class Entity: ICreatable, IDeletable, IUpdatable{
                public void Create(){
                    throw  new NotImplementedException();
                }
                public void Delete(){
                    throw  new NotImplementedException();
                }
                public void Update(){
                    throw  new NotImplementedException();
                }
            }
        }

        class Subtask3{
            public interface IBook 
            {
                public void Read();
            }

            public interface IDevice 
            {
                public void TurnOn();
                public void TurnOff();
            }
            class ElectronicBook:  IBook, IDevice{
  
                void IBook.Read(){
                    throw  new NotImplementedException();
                }

                void IDevice.TurnOn(){
                    throw  new NotImplementedException();
                }
                void IDevice.TurnOff(){
                    throw  new NotImplementedException();
                }
            }
            public Subtask3(){
                ElectronicBook eb = new ElectronicBook();
                ((IBook)eb).Read();
                ((IDevice)eb).TurnOn();
                ((IDevice)eb).TurnOff();
                
                
            }
        }

        static void Main(){

            Console.WriteLine("Hello 3");
        }
    }
}