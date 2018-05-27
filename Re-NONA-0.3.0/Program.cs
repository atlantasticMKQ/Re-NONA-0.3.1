using Re_NONA_.Elecment;
using System.Threading;
using System;

namespace Re_NONA_.Elecment
{
    internal class Defined : Tools
    {
        private static bool a, b, c, d;

        public static bool Ifdefined { get; set; } = false;

        public void R() => waitForOutput =
                (Port.Ports[inputIndexA] == false && Port.Ports[inputIndexB] == false) ?
                a :
                (
                    (Port.Ports[inputIndexA] == false && Port.Ports[inputIndexB] == true) ?
                    c :
                    (
                        (Port.Ports[inputIndexA] == true && Port.Ports[inputIndexB] == false) ?
                        b :
                        (
                            (Port.Ports[inputIndexA] == true && Port.Ports[inputIndexB] == true) ?
                            d : a
                        )
                    )
                );
        public static void Define()
        {
            Console.WriteLine(
                "┌ - ┬ - ┬ A ┬ A ┐\n" +
                "├ - ┼ - ┼ 0 ┼ 1 ┤\n" +
                "├ B ┼ 0 ┼ a ┼ b ┤\n" +
                "└ B ┴ 1 ┴ c ┴ d ┘\n" 
                );
            Console.WriteLine(LanguageSet.Language.Data[25,Program.L]);
            Console.Write("a=");
            a = Console.ReadLine() == "0" ? false:true;
            Console.WriteLine();
            Console.Write("b=");
            b = Console.ReadLine() == "0" ? false : true;
            Console.WriteLine();
            Console.Write("c=");
            c = Console.ReadLine() == "0" ? false : true;
            Console.WriteLine();
            Console.Write("d=");
            d = Console.ReadLine() == "0" ? false : true;
            Console.WriteLine();
            Ifdefined = true;
        }
        public Defined()
        {
            stop2:
            Console.Write(LanguageSet.Language.Data[26,Program.L]);
            try
            {
                inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop2;
            }
            stop3:
            Console.Write(LanguageSet.Language.Data[27,Program.L]);
            try
            {
                inputIndexB = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop3;
            }
            stop4:
            Console.Write(LanguageSet.Language.Data[28, Program.L]);
            try
            {
                outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop4;
            }
            Console.Write(LanguageSet.Language.Data[29, Program.L]);
            switch (Console.ReadLine())
            {
                case "y":
                    ifWaitCtrl = true;
                    break;
            }
            Number++;
        }
        public Defined(uint iA, uint iB, uint o, bool iWC)
        {

            ToolsNumber = Number;
            Number++;
            inputIndexA = iA;
            inputIndexB = iB;
            outputIndex = o;
            R();
            ifWaitCtrl = iWC;
        }
        public void PreRun() => R();
    }
    internal class And : Tools
    {
        public And()
        {
            stop2:
            Console.Write(LanguageSet.Language.Data[26, Program.L]);
            try
            {
                inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop2;
            }
            stop3:
            Console.Write(LanguageSet.Language.Data[27, Program.L]);
            try
            {
                inputIndexB = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop3;
            }
            stop4:
            Console.Write(LanguageSet.Language.Data[28, Program.L]);
            try
            {
                outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop4;
            }
            Console.Write(LanguageSet.Language.Data[29, Program.L]);
            switch (Console.ReadLine())
            {
                case "y":
                    ifWaitCtrl = true;
                    break;
            }
            Number++;
        }

        public And(uint iA, uint iB, uint o, bool iWC)
        {

            ToolsNumber = Number;
            Number++;
            inputIndexA = iA;
            inputIndexB = iB;
            outputIndex = o;
            waitForOutput = Port.Ports[iA] && Port.Ports[iB];
            ifWaitCtrl = iWC;
        }

        public void PreRun() => waitForOutput = Port.Ports[inputIndexA] && Port.Ports[inputIndexB];
    }
    internal class Or : Tools
    {
        public Or()
        {
            stop2:
            Console.Write(LanguageSet.Language.Data[26, Program.L]);
            try
            {
                inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop2;
            }
            stop3:
            Console.Write(LanguageSet.Language.Data[27, Program.L]);
            try
            {
                inputIndexB = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop3;
            }
            stop4:
            Console.Write(LanguageSet.Language.Data[28, Program.L]);
            try
            {
                outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop4;
            }
            Console.Write(LanguageSet.Language.Data[29, Program.L]);
            switch (Console.ReadLine())
            {
                case "y":
                    ifWaitCtrl = true;
                    break;
            }
            Number++;
        }
        public Or(uint iA, uint iB, uint o, bool iWC)
        {
            ToolsNumber = Number;
            Number++;
            inputIndexA = iA;
            inputIndexB = iB;
            outputIndex = o;
            waitForOutput = Port.Ports[inputIndexA] || Port.Ports[inputIndexB];
            ifWaitCtrl = iWC;
        }

        public void PreRun() => waitForOutput = Port.Ports[inputIndexA] || Port.Ports[inputIndexB];
    }
    internal class Nand : Tools
    {
        public Nand()
        {
            stop2:
            Console.Write(LanguageSet.Language.Data[26, Program.L]);
            try
            {
                inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop2;
            }
            stop3:
            Console.Write(LanguageSet.Language.Data[27, Program.L]);
            try
            {
                inputIndexB = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop3;
            }
            stop4:
            Console.Write(LanguageSet.Language.Data[28, Program.L]);
            try
            {
                outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop4;
            }
            Console.Write(LanguageSet.Language.Data[29, Program.L]);
            switch (Console.ReadLine())
            {
                case "y":
                    ifWaitCtrl = true;
                    break;
            }
            Number++;
        }
        public Nand(uint iA, uint iB, uint o, bool iWC)
        {
            ToolsNumber = Number;
            Number++;
            inputIndexA = iA;
            inputIndexB = iB;
            outputIndex = o;
            waitForOutput = !Port.Ports[inputIndexA] || !Port.Ports[inputIndexB];
            ifWaitCtrl = iWC;
        }

        public void PreRun() => waitForOutput = !Port.Ports[inputIndexA] || !Port.Ports[inputIndexB];
    }
    internal class Nor : Tools
    {
        public Nor()
        {
            stop2:
            Console.Write(LanguageSet.Language.Data[26, Program.L]);
            try
            {
                inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop2;
            }
            stop3:
            Console.Write(LanguageSet.Language.Data[27, Program.L]);
            try
            {
                inputIndexB = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop3;
            }
            stop4:
            Console.Write(LanguageSet.Language.Data[28, Program.L]);
            try
            {
                outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop4;
            }
            Console.Write(LanguageSet.Language.Data[29, Program.L]);
            switch (Console.ReadLine())
            {
                case "y":
                    ifWaitCtrl = true;
                    break;
            }
            Number++;
        }
        public Nor(uint iA, uint iB, uint o, bool iWC)
        {
            ToolsNumber = Number;
            Number++;
            inputIndexA = iA;
            inputIndexB = iB;
            outputIndex = o;
            waitForOutput = !Port.Ports[inputIndexA] && !Port.Ports[inputIndexB];
            ifWaitCtrl = iWC;
        }

        public void PreRun() => waitForOutput = !Port.Ports[inputIndexA] && !Port.Ports[inputIndexB];
    }
    internal class Not : Tools
    {
        public Not()
        {
            stop2:
            Console.Write(LanguageSet.Language.Data[26, Program.L]);
            try
            {
                inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop2;
            }
            stop4:
            Console.Write(LanguageSet.Language.Data[28, Program.L]);
            try
            {
                outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop4;
            }
            Console.Write(LanguageSet.Language.Data[29, Program.L]);
            switch (Console.ReadLine())
            {
                case "y":
                    ifWaitCtrl = true;
                    break;
            }
            Number++;
        }
        public Not(uint iA, uint o, bool iWC)
        {
            ToolsNumber = Number;
            Number++;
            inputIndexA = iA;
            outputIndex = o;
            waitForOutput = !Port.Ports[inputIndexA];
            ifWaitCtrl = iWC;
        }

        public void PreRun() => waitForOutput = !Port.Ports[inputIndexA];
    }
    internal class Is : Tools
    {
        public Is()
        {
            stop2:
            Console.Write(LanguageSet.Language.Data[26, Program.L]);
            try
            {
                inputIndexA = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop2;
            }
            stop4:
            Console.Write(LanguageSet.Language.Data[28, Program.L]);
            try
            {
                outputIndex = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                goto stop4;
            }
            Console.Write(LanguageSet.Language.Data[29,Program.L]);
            switch (Console.ReadLine())
            {
                case "y":
                    ifWaitCtrl = true;
                    break;
            }
            Number++;
        }
        public Is(uint iA, uint o, bool iWC)
        {
            ToolsNumber = Number;
            Number++;
            inputIndexA = iA;
            outputIndex = o;
            waitForOutput = Port.Ports[inputIndexA];
            ifWaitCtrl = iWC;
        }

        public void PreRun() => waitForOutput = Port.Ports[inputIndexA];
    }
    internal class Port
    {
        private static bool[] ports = new bool[10000];

        public static bool[] Ports { get => ports; set => ports = value; }
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
        public void Run() => Port.Ports[outputIndex] = waitForOutput;
    }
}
namespace LanguageSet
{
    static class Language
    {
        private static string[,] data =
        {
            { "Welcome to Re-NONA-0.3.2", "欢迎使用Re-NONA-0.3.2"},
            { "Waiting for input...(new/news/run/autorun/help/set/clear/define/language/author/logo)", "指令待输入...(new/news/run/autorun/help/set/clear/define/language/author/logo)" },
            { "Runtime output ports index waiting...", "运行时显示端口待输入..."},
            { "start port:","起始端口:"},
            { "end port:","终止端口:"},

            { "Error","输入错误"},
            {"Re-NONA-0.3.2","Re-NONA-0.3.2" },
            {"Loading...","装载中..." },
            {"input stop to quit","stop 指令用于退出..." },
            {"port index:","端口序号:" },

            {"change?(y/n)","更改?(y/n)" },
            {"Type input waiting...(and/nand/or/nor/not/is/defined)","创建类型待输入...(and/nand/or/nor/not/is/defined)" },
            {"undefine","未定义" },
            {"amount:","数量:" },
            {"inputA start:","输入A起始:" },

            {"sleep:","间隔:" },
            {"inputB start:","输入B起始:" },
            {"output start:","输出起始:" },
            {"Reflash frequency waiting...(/ms)","主时钟刷新间隔待输入...(/ms)" },
            {"Press any key to start...","任意键启动..." },

            {"Input stop to quit...","stop 指令用于退出..." },
            {"All data cleared","一切数据均已清除" },
            {"You have defined a elecment","你已经定义了一个类型" },
            {"Redefine?(y/n)","重新定义?(y/n)" },
            {"Supported language:English/Chinese","支持语言:英语/汉语" },

            {"Please intput a,b,c,d","请输入a,b,c,d" },
            {"inputA:","输入A:" },
            {"inputB:","输入B:" },
            {"output:","输出:" },
            {"delayable?(y/n)","可延迟?(y/n)" },
        };

        public static string[,] Data { get => data; set => data = value; }

        public static void Set()
        {
            Console.WriteLine(LanguageSet.Language.Data[24, Re_NONA_.Program.L]);
            if (Console.ReadLine() == "Chinese")
            {
                Re_NONA_.Program.L = 1;
            }
            else
            {
                Re_NONA_.Program.L = 0;
            }
        }
    }
}
namespace Re_NONA_
{
    internal class Images
    {
        public static string Author = 
                            "11111111111011111111111111111111011111111111111\n" +
                            "11111111111000001111111111110000011111111111111\n" +
                            "11111111111100000000000000000000011111111111111\n" +
                            "11111111111100000000000000000000000001111111111\n" +
                            "11111111110000000000000000000000000000000111111\n" +
                            "11111100000000000000000000000000000000000000111\n" +
                            "11000000000000000000000000000000000000000000011\n" +
                            "00000000000000000000000000000000000000000000001\n" +
                            "00000000000000000000000000000000000000000000011\n" +
                            "11101110000111111110000000100000000000000000111\n" +
                            "11111000000110111100000000000000000000000001111\n" +
                            "11111100001001111100000000000000000000000111111\n" +
                            "11111000011111111000000000000000000000000111111\n" +
                            "11100000111111111000000000000000000011000001111\n" +
                            "10000001111111110000000000000011111111100000111\n" +
                            "10000011111111100000000000000011111111111101111\n" +
                            "11001111111111100000000000000011111111111111111\n" +
                            "11111111111111110000000000000011111111111111111\n" +
                            "11111111111111111000000000000111111111111111111\n" +
                            "11111111111111111101000001111111111111111111111\n" +
                            "11111111111111111111101001111111111111111111111\n" +
                            "11111111111111111111111111111111111111111111111\n" +
                            "11111111111111111111111111111111111111111111111\n";
        public static string Logo =
                             "11111111111111111111111111111111111111111111111\n" +
                             "11111111111111111111111111111111111111111111111\n" +
                             "11111111000011001000000111000110111000111111111\n" +
                             "11111110001011011001100011010110111010011111111\n" +
                             "11111110011000011011110010010110110011011111111\n" +
                             "11111100111100011001110010111001100111101111111\n" +
                             "11111100111100011100000110111001001111100111111\n" +
                             "11111101111111011111111110111011001111100111111\n" +
                             "11111111111111111111111111111111111111111111111\n" +
                             "11111111111111111111111111111111111111111111111\n";
    }
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
            Console.WriteLine(LanguageSet.Language.Data[8,Program.L]);
            while (!ifOver)
            {
                byte portNum = 0;
                ResetPortNum:
                Console.Write(LanguageSet.Language.Data[9,Program.L]);
                try
                {
                    portNum = Convert.ToByte(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(LanguageSet.Language.Data[5,Program.L]);
                    goto ResetPortNum;
                }
                Console.WriteLine("Now:[{0}]{1}", portNum, Port.Ports[portNum] ? "1" : "0");
                Console.WriteLine(LanguageSet.Language.Data[10,Program.L]);
                switch (Console.ReadLine())
                {
                    case "y":
                        Port.Ports[portNum] = !Port.Ports[portNum];
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
            Console.WriteLine(LanguageSet.Language.Data[11,Program.L]);
            switch (Console.ReadLine())
            {
                case "and":
                    ToolsData.Tools1[Tools.Number] = new And();
                    break;
                case "nand":
                    ToolsData.Tools1[Tools.Number] = new Nand();
                    break;
                case "or":
                    ToolsData.Tools1[Tools.Number] = new Or();
                    break;
                case "nor":
                    ToolsData.Tools1[Tools.Number] = new Nor();
                    break;
                case "not":
                    ToolsData.Tools1[Tools.Number] = new Not();
                    break;
                case "is":
                    ToolsData.Tools1[Tools.Number] = new Is();
                    break;
                case "defined":
                    if (Elecment.Defined.Ifdefined == false)
                    {
                        Elecment.Defined.Define();
                    }
                    ToolsData.Tools1[Tools.Number] = new Defined();
                    break;
                case "stop":
                    break;
                default:
                    Console.WriteLine(LanguageSet.Language.Data[12,Program.L]);
                    break;
            }
        }
        public static void Plural()
        {
            Console.WriteLine(LanguageSet.Language.Data[11,Program.L]);
            switch (Console.ReadLine())
            {
                case "and":
                    Reand:
                    try
                    {
                        uint num, iA, distanceOfiA, iB, distanceOfiB, o, distanceOfo;
                        GetInput2to1(out num, out iA, out distanceOfiA, out iB, out distanceOfiB, out o, out distanceOfo);
                        for (uint i = 0; i < num; i++)
                        {
                            ToolsData.Tools1[Tools.Number] = new And(iA, iB, o, false);
                            iA += distanceOfiA;
                            iB += distanceOfiB;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine(LanguageSet.Language.Data[5,Program.L]);
                        goto Reand;
                    }
                case "nand":
                    Renand:
                    try
                    {
                        uint num, iA, distanceOfiA, iB, distanceOfiB, o, distanceOfo;
                        GetInput2to1(out num, out iA, out distanceOfiA, out iB, out distanceOfiB, out o, out distanceOfo);
                        for (int j = 0; j < num; j++)
                        {
                            ToolsData.Tools1[Tools.Number] = new Nand(iA, iB, o, false);
                            iA += distanceOfiA;
                            iB += distanceOfiB;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                        goto Renand;
                    }
                case "or":
                    Reor:
                    try
                    {
                        uint num, iA, distanceOfiA, iB, distanceOfiB, o, distanceOfo;
                        GetInput2to1(out num, out iA, out distanceOfiA, out iB, out distanceOfiB, out o, out distanceOfo);
                        for (int k = 0; k < num; k++)
                        {
                            ToolsData.Tools1[Tools.Number] = new Or(iA, iB, o, false);
                            iA += distanceOfiA;
                            iB += distanceOfiB;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                        goto Reor;
                    }
                case "nor":
                    Renor:
                    try
                    {
                        uint num, iA, distanceOfiA, iB, distanceOfiB, o, distanceOfo;
                        GetInput2to1(out num, out iA, out distanceOfiA, out iB, out distanceOfiB, out o, out distanceOfo);
                        for (int m = 0; m < num; m++)
                        {
                            ToolsData.Tools1[Tools.Number] = new Nor(iA, iB, o, false);
                            iA += distanceOfiA;
                            iB += distanceOfiB;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                        goto Renor;
                    }
                case "not":
                    Renot:
                    try
                    {
                        uint num, i, distanceOfi, o, distanceOfo;
                        GetInput1to1(out num, out i, out distanceOfi, out o, out distanceOfo);
                        for (int n = 0; n < num; n++)
                        {
                            ToolsData.Tools1[Tools.Number] = new Not(i, o, false);
                            i += distanceOfi;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                        goto Renot;
                    }
                case "is":
                    Reis:
                    try
                    {
                        uint num, i, distanceOfi, o, distanceOfo;
                        GetInput1to1(out num, out i, out distanceOfi, out o, out distanceOfo);
                        for (int n = 0; n < num; n++)
                        {
                            ToolsData.Tools1[Tools.Number] = new Is(i, o, false);
                            i += distanceOfi;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                        goto Reis;
                    }
                case "defined":
                    if (Elecment.Defined.Ifdefined == false)
                    {
                        Elecment.Defined.Define();
                    }
                    Redefined:
                    try
                    {
                        uint num, iA, distanceOfiA, iB, distanceOfiB, o, distanceOfo;
                        GetInput2to1(out num, out iA, out distanceOfiA, out iB, out distanceOfiB, out o, out distanceOfo);
                        for (uint i = 0; i < num; i++)
                        {
                            ToolsData.Tools1[Tools.Number] = new Defined(iA, iB, o, false);
                            iA += distanceOfiA;
                            iB += distanceOfiB;
                            o += distanceOfo;
                        }
                        break;
                    }
                    catch
                    {
                        Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                        goto Redefined;
                    }
                case "stop":
                    break;
                default:
                    Console.WriteLine(LanguageSet.Language.Data[5, Program.L]);
                    break;
            }
        }

        private static void GetInput1to1(out uint num, out uint i, out uint distanceOfi, out uint o, out uint distanceOfo)
        {
            Console.Write(LanguageSet.Language.Data[13, Program.L]);
            num = Convert.ToUInt32(Console.ReadLine());
            Console.Write(LanguageSet.Language.Data[14, Program.L]);
            i = Convert.ToUInt32(Console.ReadLine());
            Console.Write(LanguageSet.Language.Data[15, Program.L]);
            distanceOfi = Convert.ToUInt32(Console.ReadLine());
            Console.Write(LanguageSet.Language.Data[17, Program.L]);
            o = Convert.ToUInt32(Console.ReadLine());
            Console.Write(LanguageSet.Language.Data[15, Program.L]);
            distanceOfo = Convert.ToUInt32(Console.ReadLine());
        }

        private static void GetInput2to1(out uint num, out uint iA, out uint distanceOfiA, out uint iB, out uint distanceOfiB, out uint o, out uint distanceOfo)
        {
            Console.Write(LanguageSet.Language.Data[13, Program.L]);
            num = Convert.ToUInt32(Console.ReadLine());
            Console.Write(LanguageSet.Language.Data[14, Program.L]);
            iA = Convert.ToUInt32(Console.ReadLine());
            Console.Write(LanguageSet.Language.Data[15, Program.L]);
            distanceOfiA = Convert.ToUInt32(Console.ReadLine());
            Console.Write(LanguageSet.Language.Data[16, Program.L]);
            iB = Convert.ToUInt32(Console.ReadLine());
            Console.Write(LanguageSet.Language.Data[15, Program.L]);
            distanceOfiB = Convert.ToUInt32(Console.ReadLine());
            Console.Write(LanguageSet.Language.Data[17, Program.L]);
            o = Convert.ToUInt32(Console.ReadLine());
            Console.Write(LanguageSet.Language.Data[15, Program.L]);
            distanceOfo = Convert.ToUInt32(Console.ReadLine());
        }

        public static void AutoRun(uint startPort, uint endPort)
        {
            bool ifOver = false;
            int overTime = 0;
            int slpTime = 1;
            ResetSlptime:
            Console.WriteLine(LanguageSet.Language.Data[18,Program.L]);
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
                Console.WriteLine(LanguageSet.Language.Data[5,Program.L]);
                goto ResetSlptime;
            }
            Console.WriteLine(LanguageSet.Language.Data[19,Program.L]);
            Console.ReadLine();
            for (uint j = startPort; j <= endPort; j++)
            {
                Console.Write("[{0}]{1}", j, Port.Ports[j] ? "1" : "0");
                Console.Write("\n");

            }
            Thread.Sleep(slpTime);
            while (!ifOver)
            {
                TestRun();
                for (uint j = startPort; j <= endPort; j++)
                {
                    Console.Write("[{0}]{1}", j, Port.Ports[j] ? "1" : "0");
                    Console.Write("\n");
                }
                Console.WriteLine();
                Thread.Sleep(slpTime);
                overTime++;
                if (overTime == 50)
                {
                    ifOver = true;
                }
            }
        }
        public static void Run(uint startPort, uint endPort)
        {
            bool isOver = false;
            string input = null;
            Console.WriteLine(LanguageSet.Language.Data[20,Program.L]);
            for (uint j = startPort; j <= endPort; j++)
            {
                Console.Write("[{0}]{1}", j, Port.Ports[j] ? "1" : "0");
                Console.Write("\n");
            }
            Console.ReadLine();
            while (!isOver)
            {
                TestRun();
                for (uint j = startPort; j <= endPort; j++)
                {
                    Console.Write("[{0}]{1}", j, Port.Ports[j] ? "1" : "0");
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
                if (ToolsData.Tools1[i].ifWaitCtrl == true)
                {
                    PreRun(i);
                    ToolsData.Tools1[i].Run();
                    PreRun(i);
                }
            }
            for (int j = 0; j < 1000; j++)
            {
                for (int i = 0; i < Tools.Number; i++)
                {
                    if (ToolsData.Tools1[i].ifWaitCtrl == false)
                    {
                        PreRun(i);
                        ToolsData.Tools1[i].Run();
                        PreRun(i);
                    }
                }
            }


        }
        public static void Clear()
        {
            for (int i = 0; i < Port.Ports.Length; i++)
            {
                Port.Ports[i] = false;
            }
            for (int i = 0; i < ToolsData.Tools1.Length; i++)
            {
                ToolsData.Tools1[i] = null;
            }
            Tools.Number = 0;
            Console.WriteLine(LanguageSet.Language.Data[21, Program.L]);
        }
        public static void PreRun(int i)
        {
            if (ToolsData.Tools1[i] is And)
            {
                ((And)ToolsData.Tools1[i]).PreRun();
            }
            else if (ToolsData.Tools1[i] is Nand)
            {
                ((Nand)ToolsData.Tools1[i]).PreRun();
            }
            else if (ToolsData.Tools1[i] is Or)
            {
                ((Or)ToolsData.Tools1[i]).PreRun();
            }
            else if (ToolsData.Tools1[i] is Nor)
            {
                ((Nor)ToolsData.Tools1[i]).PreRun();
            }
            else if (ToolsData.Tools1[i] is Not)
            {
                ((Not)ToolsData.Tools1[i]).PreRun();
            }
            else if (ToolsData.Tools1[i] is Is)
            {
                ((Is)ToolsData.Tools1[i]).PreRun();
            }
            else if (ToolsData.Tools1[i] is Defined)
            {
                ((Defined)ToolsData.Tools1[i]).PreRun();
            }
        }
    }
    internal class ToolsData
    {

        internal static Tools[] Tools1 { get; set; } = new Tools[UInt16.MaxValue];
    }
    public class Program
    {
        private static int l = 0;

        public static int L { get => l; set => l = value; }

        private static void Main(string[] args)
        {
            Console.Title = LanguageSet.Language.Data[6,L];
            Console.Beep();
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.WriteLine(LanguageSet.Language.Data[7, L]);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("**************Re-NONA-0.3.2***************");
            
            Console.WriteLine(LanguageSet.Language.Data[0,L]);
            
            
            while (true)
            {
                Console.WriteLine(LanguageSet.Language.Data[1,L]);
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
                            Console.WriteLine(LanguageSet.Language.Data[2,L]);
                            Console.Write(LanguageSet.Language.Data[3,L]);
                            uint startPort = Convert.ToUInt32(Console.ReadLine());
                            Console.Write(LanguageSet.Language.Data[4,L]);
                            uint endPort = Convert.ToUInt32(Console.ReadLine());
                            Ctrl.Run(startPort, endPort);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine(LanguageSet.Language.Data[5,L]);
                            goto Rerun;
                        }
                    case "autorun":
                        Reautorun:
                        try
                        {
                            Console.WriteLine(LanguageSet.Language.Data[2,L]);
                            Console.Write(LanguageSet.Language.Data[3,L]);
                            uint startPort = Convert.ToUInt32(Console.ReadLine());
                            Console.Write(LanguageSet.Language.Data[4,L]);
                            uint endPort = Convert.ToUInt32(Console.ReadLine());
                            Ctrl.AutoRun(startPort, endPort);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine(LanguageSet.Language.Data[5,L]);
                            goto Reautorun;
                        }
                    case "help":
                        Ctrl.Help();
                        break;
                    case "set":
                        Ctrl.Set();
                        break;
                    case "author":
                        Console.WriteLine(Images.Author);
                        break;
                    case "logo":
                        Console.WriteLine(Images.Logo);
                        break;
                    case "clear":
                        Ctrl.Clear();
                        break;
                    case "define":
                        if (Defined.Ifdefined == true)
                        {
                            Console.WriteLine(LanguageSet.Language.Data[22, L]);
                            Console.WriteLine(LanguageSet.Language.Data[23, L]);
                            if (Console.ReadLine() == "n")
                            {
                                break;
                            }
                        }
                        Defined.Define();
                        break;
                    case "language":
                        LanguageSet.Language.Set();
                        break;
                    default:
                        Console.WriteLine(LanguageSet.Language.Data[5,L]);
                        break;


                }
            }
        }
    }

}

