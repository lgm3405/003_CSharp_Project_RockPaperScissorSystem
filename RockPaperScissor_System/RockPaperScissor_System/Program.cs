using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor_System
{
    public class Program                  // 컴퓨터와 가위바위보 대결 시스템
    {
        static void Main(string[] args)
        {
            int inputNumber = 0;            // 유저 입력값 받는 변수

            Console.WriteLine("1 ~ 3 사이의 숫자 값을 입력해주세요 -> ");         // 1 = 바위, 2 = 보, 3 = 가위
            int.TryParse(Console.ReadLine(), out inputNumber);               // 유저 입력을 받는다.

            int com = 2;              // 1 = 바위, 2 = 보, 3 = 가위

            if (inputNumber == 3)           // if 문 사용하여 컴퓨터가 낸 것과 비교
            {
                Console.WriteLine("승리!! ^^/");
            }
            else if (inputNumber == 2)
            {
                Console.WriteLine("비겼다..");
            }
            else
            {
                Console.WriteLine("패배.. ㅠㅠ");
            }
        }
    }
}
