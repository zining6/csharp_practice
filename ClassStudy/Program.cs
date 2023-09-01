using System;

namespace ClassStudy
{
    //类于结构体
    class Animal {
        public String name;
        public int age;
        public Animal() {
            System.Console.WriteLine("Animal的无参构造函数");
        }
        public Animal(String name, int age) {
            this.name = name;
            this.age = age;
            System.Console.WriteLine("Animal的有参构造函数");
        }

        //方法重写（虚方法与override的使用）   https://blog.csdn.net/kj297296053/article/details/8213550
        public virtual  void Eat() {
            System.Console.WriteLine("Animal的Eat虚方法方法");
        }

       
    }

    class Cat : Animal {
        public String special;

        public Cat():base() {
            System.Console.WriteLine("Cat的无参构造方法");
        }

        public Cat(String name, int age, String special) : base(name, age) {
            this.special = special;
            System.Console.WriteLine("Cat的有参构造方法");
        }

        public override void Eat()
        {
            System.Console.WriteLine("Cat的Eat普通成员方法");
        }

        
        

    }


    class Program
    {
        static void Main2(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Animal animal = new Animal("h1", 100);
            System.Console.WriteLine(animal.name+"  "+animal.age);
            animal.Eat();
            System.Console.WriteLine("===============");
            Cat cat1 = new Cat("h2", 10, "喵喵叫");
            System.Console.WriteLine(cat1.name + "  " + cat1.age + "  " + cat1.special);
            cat1.Eat();
            System.Console.WriteLine("===============");
            Animal animal1= new Cat("h3", 20, "喵喵叫(符合)");
            animal1.Eat();
        }
    }
}
