namespace study1
{
    class testClass
    {
        public string classString; //클래스 내에 선언된 요소들을 멤버라고 한다.
        public int classInt;
        public int classInt2;
        public void ClassMethod(int classint)
        {
            this.classInt = classint;// this.변수이름 은 클래스안에 소속된 메소드에서 사용하는 변수이름과 클래스에서 사용하는 변수 이름이 같을 때 this를 붙여 클래스에서 사용하는 변수임을
            // 나타내는 방법이다.
        }

        public testClass()//생성자
        {
            this.classInt = 123;
        }
        public testClass(int classint2) //classint2를 입력받으면
        {
            this.classInt = 123;
            this.classInt2 = classint2; //testclass의 classint2에 입력받은 classint2대입
        }
        /*public testClass(int classint2) : this() //this()는 생성자에만 사용 가능하며 생성자를 불러온다. 이 코드는 testClass()을 호출한 뒤에 testClass(int classint2)를 호출한것과 같다.
        {
            
            this.classInt2 = classint2;
        }*/




    }
}

namespace study1
{
    class legacy : testClass //클래스 상속 방법 : 상속해줄 클래스 이름 -> 상속해주는 클래스가 가진 모든 public을 사용가능
    {
        public int legacyInt;
        public legacy(){
            Console.WriteLine("legacy class");
        }
        
    }
    internal class Program
    {
        static void method(string name) { // 메소드 = 함수 하지만 함수는 클래스 바깥에서도 존재하지만 메소드는 반드시 클래스 안에서만 선언됨
            int localNum = 0;
            
            static void localMethod(int localNum) { // 메소드 안의 함수-> 로컬함수 는 메소드 안에만 존재하는 변수를 입력받아 사용가능
            
            
            }
            
            return; //void 함수여도 return; 을 통해서 함수 종결 가능
        
         
        }
        static void paramsStudy(params int[] arr)// 함수에 넣는 인수를 여러개로 사용가능 params와 배열을 사용해서 작동한다. 
        {

        }
        

        static void Main(string[] args)
        {

            legacy legacy = new legacy();

            int[] array=new int[] { 1,2,3,4,5};
            foreach (int i in array) { // for문을 이용한 배열 탐색과 비슷 예시) for(int i=0;i<length.arr;i++) 과 같은 문구
                Console.WriteLine(i);
            }
            var match = (int[] array) => array is [int, > 10, _];// => 이게 뭘까 => -> 람다 표현? => switch case 에서 스위치식

            switch (array[0]) {       // ==> 변수형(ex) int) 할당받을 변수= array[0] switch{  }
                case 0:               // ==> 0=>할당받을 변수에 넣을 원소, ex) 문자열로 할당할 거면 문자열 정수면 정수 
                    break;            //    break; 는 필요 없음
                    default:          // _ => 할당받을 변수에 넣을 원소 : 맨 마지막이기 때문에 , 넣을 필요 없음
                    break;            //
            }                         //

            array[1]=array[0] switch // 스위치식은 반드시 결과물을 출력해야 하기때문에 결과값을 할당할 무언가가 필요하다.
            {
                0 => array[0] = 1,
                1 => array[0] = 2,
                _ => array[0] = 3

            };

            method(name: "test");// 함수에 인자를 넣을 때 그냥 순서대로 넣을 수도 있지만 함수의 인자 이름을 이용해 할당할 수 있다. 가독성을 크게 올리기 때문에 사용할만 하다.
            //ex) 함수이름(함수선언할 때 사용한 변수 이름: 함수에 넣을 인자 값) -> static void method(string name){}
            

            testClass testClass = new testClass();
            testClass.classInt = 1;
            testClass.ClassMethod(1);
            testClass.classString = "test";


        }
    }
}
