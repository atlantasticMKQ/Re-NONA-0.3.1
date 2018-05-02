namespace Re_NONA_.Elecment
{
    using System;
    using System.Threading;
    internal class And : Tools
    {
        public And()
        {
            stop2:
            Console.Write("输入A:");
            try
            {
                base.inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop2;
            }
            stop3:
            Console.Write("输入B:");
            try
            {
                base.inputIndexB = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop3;
            }
            stop4:
            Console.Write("输出:");
            try
            {
                base.outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop4;
            }
            Console.Write("可延迟?(y/n)");
            switch (Console.ReadLine())
            {
                case "y":
                    base.ifWaitCtrl = true;
                    break;
            }
            Tools.Number++;
        }

        public And(uint iA, uint iB, uint o, bool iWC)
        {

            base.ToolsNumber = Tools.Number;
            Tools.Number++;
            base.inputIndexA = iA;
            base.inputIndexB = iB;
            base.outputIndex = o;
            base.waitForOutput = Port.ports[iA] && Port.ports[iB];
            base.ifWaitCtrl = iWC;
        }

        public void PreRun()
        {
            base.waitForOutput = Port.ports[base.inputIndexA] && Port.ports[base.inputIndexB];
        }
    }
    internal class Or : Tools
    {
        public Or()
        {
            stop2:
            Console.Write("输入A:");
            try
            {
                base.inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop2;
            }
            stop3:
            Console.Write("输入B:");
            try
            {
                base.inputIndexB = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop3;
            }
            stop4:
            Console.Write("输出:");
            try
            {
                base.outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop4;
            }
            Console.Write("可延迟?(y/n)");
            switch (Console.ReadLine())
            {
                case "y":
                    base.ifWaitCtrl = true;
                    break;
            }
            Tools.Number++;
        }
        public Or(uint iA, uint iB, uint o, bool iWC)
        {
            base.ToolsNumber = Tools.Number;
            Tools.Number++;
            base.inputIndexA = iA;
            base.inputIndexB = iB;
            base.outputIndex = o;
            base.waitForOutput = Port.ports[base.inputIndexA] || Port.ports[base.inputIndexB];
            base.ifWaitCtrl = iWC;
        }

        public void PreRun()
        {
            base.waitForOutput = Port.ports[base.inputIndexA] || Port.ports[base.inputIndexB];
        }
    }
    internal class Nand : Tools
    {
        public Nand()
        {
            stop2:
            Console.Write("输入A:");
            try
            {
                base.inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop2;
            }
            stop3:
            Console.Write("输入B:");
            try
            {
                base.inputIndexB = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop3;
            }
            stop4:
            Console.Write("输出:");
            try
            {
                base.outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop4;
            }
            Console.Write("可延迟?(y/n)");
            switch (Console.ReadLine())
            {
                case "y":
                    base.ifWaitCtrl = true;
                    break;
            }
            Tools.Number++;
        }
        public Nand(uint iA, uint iB, uint o, bool iWC)
        {
            base.ToolsNumber = Tools.Number;
            Tools.Number++;
            base.inputIndexA = iA;
            base.inputIndexB = iB;
            base.outputIndex = o;
            base.waitForOutput = !Port.ports[base.inputIndexA] || !Port.ports[base.inputIndexB];
            base.ifWaitCtrl = iWC;
        }

        public void PreRun()
        {
            base.waitForOutput = !Port.ports[base.inputIndexA] || !Port.ports[base.inputIndexB];
        }
    }
    internal class Nor : Tools
    {
        public Nor()
        {
            stop2:
            Console.Write("输入A:");
            try
            {
                base.inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop2;
            }
            stop3:
            Console.Write("输入B:");
            try
            {
                base.inputIndexB = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop3;
            }
            stop4:
            Console.Write("输出:");
            try
            {
                base.outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop4;
            }
            Console.Write("可延迟?(y/n)");
            switch (Console.ReadLine())
            {
                case "y":
                    base.ifWaitCtrl = true;
                    break;
            }
            Tools.Number++;
        }
        public Nor(uint iA, uint iB, uint o, bool iWC)
        {
            base.ToolsNumber = Tools.Number;
            Tools.Number++;
            base.inputIndexA = iA;
            base.inputIndexB = iB;
            base.outputIndex = o;
            base.waitForOutput = !Port.ports[base.inputIndexA] && !Port.ports[base.inputIndexB];
            base.ifWaitCtrl = iWC;
        }

        public void PreRun()
        {
            base.waitForOutput = !Port.ports[base.inputIndexA] && !Port.ports[base.inputIndexB];
        }
    }
    internal class Not : Tools
    {
        public Not()
        {
            stop2:
            Console.Write("输入:");
            try
            {
                base.inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop2;
            }
            stop4:
            Console.Write("输出:");
            try
            {
                base.outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop4;
            }
            Console.Write("可延迟?(y/n)");
            switch (Console.ReadLine())
            {
                case "y":
                    base.ifWaitCtrl = true;
                    break;
            }
            Tools.Number++;
        }
        public Not(uint iA, uint o, bool iWC)
        {
            base.ToolsNumber = Tools.Number;
            Tools.Number++;
            base.inputIndexA = iA;
            base.outputIndex = o;
            base.waitForOutput = !Port.ports[base.inputIndexA];
            base.ifWaitCtrl = iWC;
        }

        public void PreRun()
        {
            base.waitForOutput = !Port.ports[base.inputIndexA];
        }
    }
    internal class Is : Tools
    {
        public Is()
        {
            stop2:
            Console.Write("输入:");
            try
            {
                base.inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop2;
            }
            stop4:
            Console.Write("输出:");
            try
            {
                base.outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto stop4;
            }
            Console.Write("可延迟?(y/n)");
            switch (Console.ReadLine())
            {
                case "y":
                    base.ifWaitCtrl = true;
                    break;
            }
            Tools.Number++;
        }
        public Is(uint iA, uint o, bool iWC)
        {
            base.ToolsNumber = Tools.Number;
            Tools.Number++;
            base.inputIndexA = iA;
            base.outputIndex = o;
            base.waitForOutput = Port.ports[base.inputIndexA];
            base.ifWaitCtrl = iWC;
        }

        public void PreRun()
        {
            base.waitForOutput = Port.ports[base.inputIndexA];
        }
    }
    internal class Port
    {
        public static bool[] ports = new bool[10000];
    }
    internal class Tools
    {
        public uint inputIndexA;
        public uint inputIndexB;
        public static uint Number = 0;
        public uint outputIndex;
        public uint ToolsNumber;
        public bool waitForOutput;
        public bool ifWaitCtrl = false;
        public void Run()
        {

            Port.ports[this.outputIndex] = this.waitForOutput;

        }
    }
}
namespace Re_NONA_
{
    using Re_NONA_.Elecment;
    using System.Threading;
    using System;
    internal class Ctrl
    {
        public static void Help()
        {//"本游戏由端口替代导线,允许玩家在端口之间创建逻辑门\n" +
            //"目前支持的逻辑门有:\n" +
            //"->And:仅当两个输入端同时有电时才输出电流\n" +
            //"->Or:只要有一个输入端有电便输出电流\n" +
            //"->Nand:仅当两个输入端口都有电时才不输出电流\n" +
            //"->Nor:仅当两个输入端口都没电时才输出电流\n" +
            //"->Not:输入端口与输出端口状态相反\n\n" +
            //"目前的版本不支持会造成矛盾的电路所带来的快速变化电流(端口除非改变,通电状态应该是一定的)\n" +
            //"如果输入错误会导致程序崩溃而非重新输入\n" +
            //"true:有电false:没电\n" +
            //"支持的指令如下:\n" +
            //"->new:创建新元件\n" +
            //"->check:检查元件状态\n" +
            //"->run:运行元件\n" +
            //"->ports:显示端口状态(待改进)\n" +
            Console.WriteLine();
            Console.WriteLine("******欢迎使用Re-NONA-0.3.0******");
            Console.WriteLine(
                "Re-NONA-是一款逻辑门电路创建游戏,\n" +
                "在游戏中,玩家可以了解到计算机的原理以及亲身体验发展过程");
            Console.WriteLine(
                "元件说明:元件是建立在端口之间的能对电路变化产生反应的器件\n" +
                "->And:仅当两个输入端同时有电时才输出电流\n" +
                "->Or:只要有一个输入端有电便输出电流\n" +
                "->Nand:仅当两个输入端口都有电时才不输出电流\n" +
                "->Nor:仅当两个输入端口都没电时才输出电流\n" +
                "->Not:输入端口与输出端口状态相反\n" +
                "->Is:输入端口与输出端口状态相同\n ");
            Console.WriteLine(
                "端口说明:端口是连接在元件之间传递电路变化的器件\n" +
                "可以认为一个端口就是一根导线");
            Console.WriteLine("功能介绍:");
            Console.WriteLine(
                "->New:在端口之间创建新的逻辑门元件\n" +
                "->News:一次性创建多个元件\n" +
                "->Run:运行电路\n" +
                "->AutoRun:自动运行500次\n" +
                "");
            Console.WriteLine("可延迟元件说明");
            Console.WriteLine("玩家可以创建延迟元件,这种元件从收到输入端的改变后,\n将其反馈到输出端需要一定的时间");
        }
        public static void Set()
        {
            bool ifOver = false;
            Console.WriteLine("设置结束请输入stop");
            while (!ifOver)
            {
                byte portNum = 0;
                ResetPortNum:
                Console.Write("端口号:");
                try
                {
                    portNum = Convert.ToByte(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("输入错误");
                    goto ResetPortNum;
                }
                Console.WriteLine("目前状态:[{0}]{1}", portNum, Port.ports[portNum] ? "1" : "0");
                Console.WriteLine("是否更改(y/n)");
                switch (Console.ReadLine())
                {
                    case "y":
                        Port.ports[portNum] = !Port.ports[portNum];
                        break;
                    default:
                        break;
                }
                if (Console.ReadLine() == "stop")
                {
                    ifOver = true;
                }


            }
        }
        public static void New()
        {
            Console.WriteLine("创建类型待输入...(and/nand/or/nor/not/is)");
            switch (Console.ReadLine())
            {
                case "and":
                    ToolsData.tools1[Tools.Number] = new And();
                    break;
                case "nand":
                    ToolsData.tools1[Tools.Number] = new Nand();
                    break;
                case "or":
                    ToolsData.tools1[Tools.Number] = new Or();
                    break;
                case "nor":
                    ToolsData.tools1[Tools.Number] = new Nor();
                    break;
                case "not":
                    ToolsData.tools1[Tools.Number] = new Not();
                    break;
                case "is":
                    ToolsData.tools1[Tools.Number] = new Is();
                    break;
                default:
                    Console.WriteLine("未定义之指令");
                    break;
            }
        }
        public static void Plural()
        {
            Console.WriteLine("批量创建类型待输入...(and/nand/or/nor/not/is)");
            switch (Console.ReadLine())
            {
                case "and":
                    Reand:
                    try
                    {
                        Console.Write("创建个数:");
                        uint num = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入A起始:");
                        uint iA = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔:");
                        uint distanceOfiA = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入B起始:");
                        uint iB = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔:");
                        uint distanceOfiB = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输出起始:");
                        uint o = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔:");
                        uint distanceOfo = Convert.ToUInt32(Console.ReadLine());
                        for (uint i = 0; i < num; i++)
                        {
                            ToolsData.tools1[Tools.Number] = new And(iA, iB, o, false);
                            iA += distanceOfiA;
                            iB += distanceOfiB;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("输入错误");
                        goto Reand;
                    }
                case "nand":
                    Renand:
                    try
                    {
                        Console.Write("创建个数:");
                        uint num = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入A起始:");
                        uint iA = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfiA = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入B起始:");
                        uint iB = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfiB = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输出起始:");
                        uint o = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfo = Convert.ToUInt32(Console.ReadLine());
                        for (int j = 0; j < num; j++)
                        {
                            ToolsData.tools1[Tools.Number] = new Nand(iA, iB, o, false);
                            iA += distanceOfiA;
                            iB += distanceOfiB;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("输入错误");
                        goto Renand;
                    }
                case "or":
                    Reor:
                    try
                    {
                        Console.Write("创建个数:");
                        uint num = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入A起始:");
                        uint iA = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfiA = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入B起始:");
                        uint iB = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfiB = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输出起始:");
                        uint o = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfo = Convert.ToUInt32(Console.ReadLine());
                        for (int k = 0; k < num; k++)
                        {
                            ToolsData.tools1[Tools.Number] = new Or(iA, iB, o, false);
                            iA += distanceOfiA;
                            iB += distanceOfiB;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("输入错误");
                        goto Reor;
                    }
                case "nor":
                    Renor:
                    try
                    {
                        Console.Write("创建个数:");
                        uint num = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入A起始:");
                        uint iA = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfiA = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入B起始:");
                        uint iB = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfiB = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输出起始:");
                        uint o = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfo = Convert.ToUInt32(Console.ReadLine());
                        for (int m = 0; m < num; m++)
                        {
                            ToolsData.tools1[Tools.Number] = new Nor(iA, iB, o, false);
                            iA += distanceOfiA;
                            iB += distanceOfiB;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("输入错误");
                        goto Renor;
                    }
                case "not":
                    Renot:
                    try
                    {
                        Console.Write("创建个数:");
                        uint num = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入起始:");
                        uint i = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfi = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输出起始:");
                        uint o = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfo = Convert.ToUInt32(Console.ReadLine());
                        for (int n = 0; n < num; n++)
                        {
                            ToolsData.tools1[Tools.Number] = new Not(i, o, false);
                            i += distanceOfi;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("输入错误");
                        goto Renot;
                    }
                case "is":
                    Reis:
                    try
                    {
                        Console.Write("创建个数:");
                        uint num = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入起始:");
                        uint i = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfi = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输出起始:");
                        uint o = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint distanceOfo = Convert.ToUInt32(Console.ReadLine());
                        for (int n = 0; n < num; n++)
                        {
                            ToolsData.tools1[Tools.Number] = new Is(i, o, false);
                            i += distanceOfi;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("输入错误");
                        goto Reis;
                    }
                default:
                    Console.WriteLine("未定义之指令");
                    break;
            }
        }
        public static void AutoRun(uint startPort, uint endPort)
        {
            bool ifOver = false;
            int overTime = 0;
            int slpTime = 1;
            ResetSlptime:
            Console.WriteLine("主时钟刷新间隔待输入...(/ms)");
            try
            {
                slpTime = Convert.ToInt32(Console.ReadLine());
                if (slpTime < 0)
                {
                    slpTime = -slpTime;
                }
            }
            catch
            {
                Console.WriteLine("输入错误");
                goto ResetSlptime;
            }
            Console.WriteLine("任意键启动...");
            Console.ReadLine();
            for (uint j = startPort; j <= endPort; j++)
            {
                Console.Write("[{0}]{1}", j, Port.ports[j] ? "1" : "0");
                Console.Write("\n");

            }
            Thread.Sleep(slpTime);
            while (!ifOver)
            {
                TestRun();
                for (uint j = startPort; j <= endPort; j++)
                {
                    Console.Write("[{0}]{1}", j, Port.ports[j] ? "1" : "0");
                    Console.Write("\n");
                }
                Console.WriteLine();
                Thread.Sleep(slpTime);
                overTime++;
                if (overTime == 500)
                {
                    ifOver = true;
                }
            }
        }
        public static void Run(uint startPort, uint endPort)
        {
            bool isOver = false;
            string input = null;
            Console.WriteLine("stop 指令用于退出...");
            for (uint j = startPort; j <= endPort; j++)
            {
                Console.Write("[{0}]{1}", j, Port.ports[j] ? "1" : "0");
                Console.Write("\n");
            }
            Console.ReadLine();
            while (!isOver)
            {
                TestRun();
                for (uint j = startPort; j <= endPort; j++)
                {
                    Console.Write("[{0}]{1}", j, Port.ports[j] ? "1" : "0");
                    Console.Write("\n");
                }
                input = Console.ReadLine();
                if (input == "stop")
                {
                    isOver = true;
                }
            }
        }
        public static void TestRun()
        {
            for (int i = 0; i < Tools.Number; i++)
            {
                if (ToolsData.tools1[i].ifWaitCtrl == true)
                {
                    PreRun(i);
                    ToolsData.tools1[i].Run();
                    PreRun(i);
                }
            }
            for (int j = 0; j < 1000; j++)
            {
                for (int i = 0; i < Tools.Number; i++)
                {
                    if (ToolsData.tools1[i].ifWaitCtrl == false)
                    {
                        PreRun(i);
                        ToolsData.tools1[i].Run();
                        PreRun(i);
                    }
                }
            }


        }

        public static void PreRun(int i)
        {
            if (ToolsData.tools1[i] is And)
            {
                ((And)ToolsData.tools1[i]).PreRun();
            }
            else if (ToolsData.tools1[i] is Nand)
            {
                ((Nand)ToolsData.tools1[i]).PreRun();
            }
            else if (ToolsData.tools1[i] is Or)
            {
                ((Or)ToolsData.tools1[i]).PreRun();
            }
            else if (ToolsData.tools1[i] is Nor)
            {
                ((Nor)ToolsData.tools1[i]).PreRun();
            }
            else if (ToolsData.tools1[i] is Not)
            {
                ((Not)ToolsData.tools1[i]).PreRun();
            }
            else if (ToolsData.tools1[i] is Is)
            {
                ((Is)ToolsData.tools1[i]).PreRun();
            }
        }
    }
    internal class ToolsData
    {
        public static Tools[] tools1 = new Tools[UInt16.MaxValue];
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            Console.Title = "Re-NONA-0.3.1";
            Console.Beep();
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WriteLine("**************NONA***************");
            Console.WriteLine("欢迎使用Re-NONA-0.3.1");
            
            while (true)
            {
                Console.WriteLine("指令待输入...(new/news/run/autorun/help/set/clear/author/logo)");
                switch (Console.ReadLine())
                {
                    case "new":
                        Ctrl.New();
                        break;

                    case "news":
                        Ctrl.Plural();
                        break;

                    case "run":
                        Rerun:
                        try
                        {
                            Console.WriteLine("运行时显示端口待输入...");
                            Console.Write("起始端口:");
                            uint startPort = Convert.ToUInt32(Console.ReadLine());
                            Console.Write("终止端口:");
                            uint endPort = Convert.ToUInt32(Console.ReadLine());
                            Ctrl.Run(startPort, endPort);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("输入错误");
                            goto Rerun;
                        }
                    case "autorun":
                        Reautorun:
                        try
                        {
                            Console.WriteLine("运行时显示端口待输入...");
                            Console.Write("起始端口:");
                            uint startPort = Convert.ToUInt32(Console.ReadLine());
                            Console.Write("终止端口:");
                            uint endPort = Convert.ToUInt32(Console.ReadLine());
                            Ctrl.AutoRun(startPort, endPort);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("输入错误");
                            goto Reautorun;
                        }
                    case "help":
                        Ctrl.Help();
                        break;
                    case "set":
                        Ctrl.Set();
                        break;
                    case "author":
                        Console.WriteLine(
                            "11111111111011111111111111111111011111111111111\n11111111111000001111111111110000011111111111111\n11111111111100000000000000000000011111111111111\n11111111111100000000000000000000000001111111111\n11111111110000000000000000000000000000000111111\n11111100000000000000000000000000000000000000111\n11000000000000000000000000000000000000000000011\n00000000000000000000000000000000000000000000001\n00000000000000000000000000000000000000000000011\n11101110000111111110000000100000000000000000111\n11111000000110111100000000000000000000000001111\n11111100001001111100000000000000000000000111111\n11111000011111111000000000000000000000000111111\n11100000111111111000000000000000000011000001111\n10000001111111110000000000000011111111100000111\n10000011111111100000000000000011111111111101111\n11001111111111100000000000000011111111111111111\n11111111111111110000000000000011111111111111111\n11111111111111111000000000000111111111111111111\n11111111111111111101000001111111111111111111111\n11111111111111111111101001111111111111111111111\n11111111111111111111111111111111111111111111111\n11111111111111111111111111111111111111111111111\n");
                        break;
                    case "logo":
                        Console.WriteLine(
                             "11111111111111111111111111111111111111111111111\n" +
                             "11111111111111111111111111111111111111111111111\n" +
                             "11111111000011001000000111000110111000111111111\n" +
                             "11111110001011011001100011010110111010011111111\n" +
                             "11111110011000011011110010010110110011011111111\n" +
                             "11111100111100011001110010111001100111101111111\n" +
                             "11111100111100011100000110111001001111100111111\n" +
                             "11111101111111011111111110111011001111100111111\n" +
                             "11111111111111111111111111111111111111111111111\n" +
                             "11111111111111111111111111111111111111111111111\n");
                        break;
                    case "clear":
                        for (int i = 0; i < Port.ports.Length; i++)
                        {
                            Port.ports[i] = false;
                        }
                        for (int i = 0; i < ToolsData.tools1.Length; i++)
                        {
                            ToolsData.tools1[i] = null;
                        }
                        Tools.Number = 0;
                        Console.WriteLine("所有数据已清除");
                        break;
                    default:
                        Console.WriteLine("未定义之指令");
                        break;


                }
            }
        }
    }

}

