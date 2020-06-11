using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool newForm = false;
            Mutex mutex = new Mutex(true, Assembly.GetExecutingAssembly().FullName, out newForm);
            //초기 소유권 가질지, name, 초기 소유권 결과값 할당
            //1. 어셈블리 이름 -> dll, exe 파일이름


            //2. mutex가 생성됬는지 check
            if(newForm == true)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            //3. 하나의 프로그램만 실행 될 수 있도록 변경

            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
        }
    }
}
