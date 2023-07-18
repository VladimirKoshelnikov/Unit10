using System;
using System.IO;

namespace Task1{
    class Program{
        class Subtask1{
            public interface IWriter{
                void Write(){ Console.WriteLine("Hello! I am Writer!");}
            } 
            public interface ILogger{
                void Write(){ Console.WriteLine("Hello! I am Logger!");}
            } 
        
            public class BusinessLogic : IWriter, ILogger{
                
            }
        }

        class Subtask2{
                      
            public class Manager : IManager
            {
                public void Create(){}

                public void Read(){}

                public void Update(){}

                public void Delete(){}
            }  

            public interface IManager{
                public void Create();
                public void Read();
                public void Update();
                public void Delete();
            }  
        }

        static void Main(){
            Console.WriteLine("Hello");
        }
    }
}