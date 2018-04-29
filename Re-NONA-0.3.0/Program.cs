namespace Re_NONA_.Elecment
{
    using System;
    using System.Threading;
    internal class And : Tools
    {
        public And(uint iA, uint iB, uint o)
        {
            base.ToolsNumber = Tools.Number;
            Tools.Number++;
            base.inputIndexA = iA;
            base.inputIndexB = iB;
            base.outputIndex = o;
            base.waitForOutput = Port.ports[iA] && Port.ports[iB];
        }

        public void PreRun()
        {
            base.waitForOutput = Port.ports[base.inputIndexA] && Port.ports[base.inputIndexB];
        }
    }
    internal class Nand : Tools
    {
        public Nand(uint iA, uint iB, uint o)
        {
            base.ToolsNumber = Tools.Number;
            Tools.Number++;
            base.inputIndexA = iA;
            base.inputIndexB = iB;
            base.outputIndex = o;
            base.waitForOutput = !Port.ports[base.inputIndexA] || !Port.ports[base.inputIndexB];
        }

        public void PreRun()
        {
            base.waitForOutput = !Port.ports[base.inputIndexA] || !Port.ports[base.inputIndexB];
        }
    }
    internal class Nor : Tools
    {
        public Nor(uint iA, uint iB, uint o)
        {
            base.ToolsNumber = Tools.Number;
            Tools.Number++;
            base.inputIndexA = iA;
            base.inputIndexB = iB;
            base.outputIndex = o;
            base.waitForOutput = !Port.ports[base.inputIndexA] && !Port.ports[base.inputIndexB];
        }

        public void PreRun()
        {
            base.waitForOutput = !Port.ports[base.inputIndexA] && !Port.ports[base.inputIndexB];
        }
    }
    internal class Not : Tools
    {
        public Not(uint iA, uint o)
        {
            base.ToolsNumber = Tools.Number;
            Tools.Number++;
            base.inputIndexA = iA;
            base.outputIndex = o;
            base.waitForOutput = !Port.ports[base.inputIndexA];
        }

        public void PreRun()
        {
            base.waitForOutput = !Port.ports[base.inputIndexA];
        }
    }
    internal class Is : Tools
    {
        public Is(uint iA, uint o)
        {
            base.ToolsNumber = Tools.Number;
            Tools.Number++;
            base.inputIndexA = iA;
            base.outputIndex = o;
            base.waitForOutput = Port.ports[base.inputIndexA];
        }

        public void PreRun()
        {
            base.waitForOutput = Port.ports[base.inputIndexA];
        }
    }
    internal class Or : Tools
    {
        public Or(uint iA, uint iB, uint o)
        {
            base.ToolsNumber = Tools.Number;
            Tools.Number++;
            base.inputIndexA = iA;
            base.inputIndexB = iB;
            base.outputIndex = o;
            base.waitForOutput = Port.ports[base.inputIndexA] || Port.ports[base.inputIndexB];
        }

        public void PreRun()
        {
            base.waitForOutput = Port.ports[base.inputIndexA] || Port.ports[base.inputIndexB];
        }
    }
    internal class Port
    {
        public static bool[] ports = new bool[0x2710];
    }
    internal class Tools
    {
        public uint inputIndexA;
        public uint inputIndexB;
        public static uint Number = 0;
        public uint outputIndex;
        public uint ToolsNumber;
        public bool waitForOutput;

        public void Run()
        {
            if (Port.ports[this.outputIndex] != this.waitForOutput)
            {
                Port.ports[this.outputIndex] = this.waitForOutput;
            }
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
                "->News(消歧义):一次性创建多个元件\n" +
                "->Run:运行电路\n" +
                "->AutoRun:自动运行,暂无法退出\n" +
                "");
        }
        public static void Set()
        {
            bool ifOver = false;
            Console.WriteLine("设置结束请输入stop");
            while(!ifOver)
            {
                byte portNum = 0;
                stop1:
                Console.Write("端口号:");
                try
                {
                    portNum = Convert.ToByte(Console.ReadLine());
                }
                catch
                {
                    goto stop1;
                }
                Console.WriteLine("目前状态:[{0}]{1}",portNum,Port.ports[portNum]?"1":"0");
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
                    {
                        uint iA, iB, o;
                        stop2:
                        Console.Write("输入A:");
                        try
                        {
                             iA = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop2;
                        }
                        stop3:
                        Console.Write("输入B:");
                        try
                        {
                            iB = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop3;
                        }
                        stop4:
                        Console.Write("输出:");
                        try
                        {
                            o = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop4;
                        }
                        ToolsData.tools[Tools.Number] = new And(iA, iB, o);
                        break;
                    }
                case "nand":
                    {
                        uint num4, num5, num6;
                        stop5:
                        Console.Write("输入A:");
                        try
                        {
                            num4 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop5;
                        }
                        stop6:
                        Console.Write("输入B:");
                        try
                        {
                            num5 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop6;
                        }
                        stop7:
                        Console.Write("输出:");
                        try
                        {
                            num6 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop7;
                        }
                        ToolsData.tools[Tools.Number] = new Nand(num4, num5, num6);
                        break;
                    }
                case "or":
                    {
                        uint num7, num8, num9;
                        stop8:
                        Console.Write("输入A:");
                        try
                        {
                            num7 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop8;
                        }
                        stop9:
                        Console.Write("输入B:");
                        try
                        {
                            num8 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop9;
                        }
                        stop10:
                        Console.Write("输出:");
                        try
                        {
                            num9 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop10;
                        }
                        ToolsData.tools[Tools.Number] = new Or(num7, num8, num9);
                        break;
                    }
                case "nor":
                    {
                        uint num10, num11, num12;
                        stop11:
                        Console.Write("输入A:");
                        try
                        {
                            num10 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop11;
                        }
                        stop12:
                        Console.Write("输入B:");
                        try
                        {
                            num11 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop12;
                        }
                        stop13:
                        Console.Write("输出:");
                        try
                        {
                            num12 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop13;
                        }
                        ToolsData.tools[Tools.Number] = new Nor(num10, num11, num12);
                        break;
                    }
                case "not":
                    {
                        uint num13, num14;
                        stop14:
                        Console.Write("输入:");
                        try
                        {
                            num13 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop14;
                        }
                        stop15:
                        Console.Write("输出:");
                        try
                        {
                            num14 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop15;
                        }
                        ToolsData.tools[Tools.Number] = new Not(num13, num14);
                        break;
                    }
                case "is":
                    {
                        uint num13, num14;
                        stop30:
                        Console.Write("输入:");
                        try
                        {
                            num13 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop30;
                        }
                        stop31:
                        Console.Write("输出:");
                        try
                        {
                            num14 = Convert.ToUInt32(Console.ReadLine());
                        }
                        catch
                        {
                            goto stop31;
                        }
                        ToolsData.tools[Tools.Number] = new Is(num13, num14);
                        break;
                    }
                default:
                    Console.WriteLine("未定义之指令");
                    break;
            }
        }

        public static void News()
        {
            Console.WriteLine("批量创建类型待输入...(and/nand/or/nor/not/is)");
            switch (Console.ReadLine())
            {
                case "and":
                    stop16:
                    try
                    {
                        Console.Write("创建个数:");
                        uint num = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入A起始:");
                        uint iA = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔:");
                        uint num3 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入B起始:");
                        uint iB = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔:");
                        uint num5 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输出起始:");
                        uint o = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔:");
                        uint num7 = Convert.ToUInt32(Console.ReadLine());
                        for (uint i = 0; i < num; i++)
                        {
                            ToolsData.tools[Tools.Number] = new And(iA, iB, o);
                            iA += num3;
                            iB += num5;
                            o += num7;
                        }
                        break;
                    }
                    catch
                    {
                        goto stop16;
                    }
                case "nand":
                    stop17:
                    try
                    {
                        Console.Write("创建个数:");
                        uint num8 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入A起始:");
                        uint num9 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num10 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入B起始:");
                        uint num11 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num12 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输出起始:");
                        uint num13 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num14 = Convert.ToUInt32(Console.ReadLine());
                        for (int j = 0; j < num8; j++)
                        {
                            ToolsData.tools[Tools.Number] = new Nand(num9, num11, num13);
                            num9 += num10;
                            num11 += num12;
                            num13 += num14;
                        }
                        break;
                    }
                    catch
                    {
                        goto stop17;
                    }
                case "or":
                    stop18:
                    try
                    {
                        Console.Write("创建个数:");
                        uint num15 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入A起始:");
                        uint num16 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num17 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入B起始:");
                        uint num18 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num19 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输出起始:");
                        uint num20 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num21 = Convert.ToUInt32(Console.ReadLine());
                        for (int k = 0; k < num15; k++)
                        {
                            ToolsData.tools[Tools.Number] = new Or(num16, num18, num20);
                            num16 += num17;
                            num18 += num19;
                            num20 += num21;
                        }
                        break;
                    }
                    catch
                    {
                        goto stop18;
                    }
                case "nor":
                    stop19:
                    try
                    {
                        Console.Write("创建个数:");
                        uint num22 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入A起始:");
                        uint num23 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num24 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入B起始:");
                        uint num25 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num26 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输出起始:");
                        uint num27 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num28 = Convert.ToUInt32(Console.ReadLine());
                        for (int m = 0; m < num22; m++)
                        {
                            ToolsData.tools[Tools.Number] = new Nor(num23, num25, num27);
                            num23 += num24;
                            num25 += num26;
                            num27 += num28;
                        }
                        break;
                    }
                    catch
                    {
                        goto stop19;
                    }
                case "not":
                    stop20:
                    try
                    {
                        Console.Write("创建个数:");
                        uint num29 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入起始:");
                        uint num30 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num31 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输出起始:");
                        uint num32 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num33 = Convert.ToUInt32(Console.ReadLine());
                        for (int n = 0; n < num29; n++)
                        {
                            ToolsData.tools[Tools.Number] = new Not(num30, num32);
                            num30 += num31;
                            num32 += num33;
                        }
                        break;
                    }
                    catch
                    {
                        goto stop20;
                    }
                case "is":
                    stop33:
                    try
                    {
                        Console.Write("创建个数:");
                        uint num29 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输入起始:");
                        uint num30 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num31 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("输出起始:");
                        uint num32 = Convert.ToUInt32(Console.ReadLine());
                        Console.Write("间隔");
                        uint num33 = Convert.ToUInt32(Console.ReadLine());
                        for (int n = 0; n < num29; n++)
                        {
                            ToolsData.tools[Tools.Number] = new Is(num30, num32);
                            num30 += num31;
                            num32 += num33;
                        }
                        break;
                    }
                    catch
                    {
                        goto stop33;
                    }
                default:
                    Console.WriteLine("未定义之指令");
                    break;
            }
        }
        public static void AutoRun(uint aa,uint bb)
        {
            bool ifOver = false;
            int slpTime = 1;
            stop21:
            Console.WriteLine("主时钟刷新间隔待输入...(/ms)");
            try
            {
                slpTime = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                goto stop21;
            }
            Console.WriteLine("任意键启动...");
            Console.ReadLine();
            for (uint j = aa; j <= bb; j++)
            {
                Console.Write("[{0}]{1}", j, Port.ports[j] ? "1" : "0");
                Console.Write("\n");
                
            }
            Thread.Sleep(slpTime);
            while (!ifOver)
            {
                
                for (int i = 0; i < Tools.Number; i++)
                {
                    if (ToolsData.tools[i] is And)
                    {
                        ((And)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Nand)
                    {
                        ((Nand)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Or)
                    {
                        ((Or)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Nor)
                    {
                        ((Nor)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Not)
                    {
                        ((Not)ToolsData.tools[i]).PreRun();
                    }
                    else if(ToolsData.tools[i] is Is)
                    {
                        ((Is)ToolsData.tools[i]).PreRun();
                    }
                    ToolsData.tools[i].Run();

                    if (ToolsData.tools[i] is And)
                    {
                        ((And)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Nand)
                    {
                        ((Nand)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Or)
                    {
                        ((Or)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Nor)
                    {
                        ((Nor)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Not)
                    {
                        ((Not)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Is)
                    {
                        ((Is)ToolsData.tools[i]).PreRun();
                    }

                }
                for (uint j = aa; j <= bb; j++)
                {
                    Console.Write("[{0}]{1}", j, Port.ports[j] ? "1" : "0");
                    Console.Write("\n");
                }

                Thread.Sleep(slpTime);
            }

        }
        public static void Run(uint aa, uint bb)
        {
            bool isOver = false;
            string input = null;
            Console.WriteLine("stop 指令用于退出...");
            for (uint j = aa; j <= bb; j++)
            {
                Console.Write("[{0}]{1}", j, Port.ports[j] ? "1" : "0");
                Console.Write("\n");
            }
            while (!isOver)
            {
                for (int i = 0; i < Tools.Number; i++)
                {
                    if (ToolsData.tools[i] is And)
                    {
                        ((And)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Nand)
                    {
                        ((Nand)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Or)
                    {
                        ((Or)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Nor)
                    {
                        ((Nor)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Not)
                    {
                        ((Not)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Is)
                    {
                        ((Is)ToolsData.tools[i]).PreRun();
                    }
                    ToolsData.tools[i].Run();
                   
                    if (ToolsData.tools[i] is And)
                    {
                        ((And)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Nand)
                    {
                        ((Nand)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Or)
                    {
                        ((Or)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Nor)
                    {
                        ((Nor)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Not)
                    {
                        ((Not)ToolsData.tools[i]).PreRun();
                    }
                    else if (ToolsData.tools[i] is Is)
                    {
                        ((Is)ToolsData.tools[i]).PreRun();
                    }

                }
                for (uint j = aa; j <= bb; j++)
                    {
                        Console.Write("[{0}]{1}", j, Port.ports[j]?"1":"0");
                        Console.Write("\n");
                    }
                input = Console.ReadLine();
                if (input == "stop")
                {
                    isOver = true;
                }

            }
        }
    }
    internal class ToolsData
    {
        public static Tools[] tools = new Tools[byte.MaxValue];
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("**************NONA***************");
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
            while (true)
            {
                Console.WriteLine("指令待输入...(new/news/run/help/set/author/logo)");
                switch (Console.ReadLine())
                {
                    case "new":
                        Ctrl.New();
                        break;

                    case "news":
                        Ctrl.News();
                        break;

                    case "run":
                        stop22:
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
                            goto stop22;
                        }
                    case "autorun":
                        stop23:
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
                            goto stop23;
                        }
                    case "help":
                        Ctrl.Help();
                        break;
                    case "set":
                        Ctrl.Set();
                        break;
                    case"author":
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
                    default:
                        Console.WriteLine("未定义之指令");
                        break;
                        

                }
            }
        }
    }
    
}

