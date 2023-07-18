using System;
using System.IO;

namespace Task4{
    class Program{
        /*
        Ковариантность позволяет использовать более конкретный тип, чем тип, который задан изначально.
        Контравариантность позволяет использовать более универсальный тип, чем тип, который задан изначально.
        */

        class Subtask1{

            /*
            Ковариантность интерфейсов реализуется с помощью ключевого слова out

            */

            public interface IMessenger <out T>{
                T DeviceInfo();
            }

            public class Viber<T>:IMessenger<T> where T:Phone, new(){
                public T DeviceInfo(){
                    T device = new T();
                    Console.WriteLine(device);
                    return new T();
                }
            }

            public class Phone{}
            public class IPhone:Phone{};
            public class Computer{};

            public Subtask1(){
                IMessenger<Phone> viberInPhone = new Viber<Phone>();
                IMessenger<Phone> viberInIPhone = new Viber<IPhone>();

                viberInPhone.DeviceInfo();
                viberInIPhone.DeviceInfo();

            }
        }

        class Subtask2{
            /*
            Контрвариантность интерфейсов реализуется с помощью ключевого слова in
            */

            public interface IMessenger<in T>{
                void GetDeviceInfo(T device);
            }

            public class Viber<T>:IMessenger<T> where T:Phone, new(){
                public void GetDeviceInfo(T device){
                    Console.WriteLine(device);
                    }
            }

            public class Phone{}
            public class IPhone:Phone{};
            public class Computer{};

            public Subtask2(){
                IMessenger<Phone> viberInPhone = new Viber<Phone>();
                viberInPhone.GetDeviceInfo(new Phone());

                IMessenger<IPhone> viberInIphone = new Viber<Phone>();
                viberInIphone.GetDeviceInfo(new IPhone());

                Console.Read();    
            }

        }

        class Subtask3 {
            /*Один класс может быть как контрfвариантным, так и ковариантным*/
            public class Car {

            }
            public class Bike:Car{

            }

            public class Home{

            }
            public class Garage:Home{

            }

            public interface IGarageManager<in T, out Z>{
                public Z GetGarageInfo();
                public void Add (T car);
            }

            public class GarageManagerBase:IGarageManager<Car, Garage>{
                public void Add(Car car){
                    throw new NotImplementedException();
                }

                public Garage GetGarageInfo(){
                    throw new NotImplementedException();
                }
            }
            public Subtask3(){
                IGarageManager<Car, Garage> gmb1 = new GarageManagerBase();
                IGarageManager<Bike, Garage> gmb2 = new GarageManagerBase();    
                IGarageManager<Car, Home> gmb3 = new GarageManagerBase();
            }
        }

        class Subtask4{

            public class User 
            {

            }

            public class Account: User 
            {

            }

            public interface IUpdater< in T> 
            {
                void Update (T entity);
            }

            class UserService:IUpdater<User>{
                public void Update(User entity){
                    throw new NotImplementedException();
                }
            }

            public Subtask4(){

                Account account = new Account();
                User user = new User();
                
                IUpdater<Account> updater = new UserService();
                var userService = new UserService();
                userService.Update(user);
                
                }
        }

        static void Main(){
            Subtask1 st1 = new Subtask1();
            Subtask2 st2 = new Subtask2();
        }
    }
}