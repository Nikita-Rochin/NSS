using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSS
{
    internal class Employee
    {
        //лиги с клубами
        public List<string> RPL = new List<string>
            {"Zenith","Spartak M","CSKA","Krasnodar","Rostov","Dynamo M","Sochi"};
        /// ///////
        public List<string> EuropaTop = new List<string>()
        {"Manchester City","Arsenal","Liverpool","Barcelona","Real Madrid","Bayern Munich","PSG","AC Milan","Internazionale","Napoli","Borussia Dortmund"};
        public List<string> Europa_above_average = new List<string>()
        {"Manchester United","Chelsea","Atletico Madrid","RB Leipzig","Juventus","FC Porto","Benfica",};
        public List<string> Europa_medium = new List<string>()
        {"Newcastle","Tottenham","Real Sociedad","Real Betis","Sevilla","Villarreal","Bayer Leverkusen","Eintracht Frankfurt","Atalanta","Lazio","AS Roma","Marseille","AS Monaco","Sporting CP"};
        public List<string> Europa_below_average = new List<string>()
        {"Brighton","West Ham","Aston Villa","Athletic Club","Mainz","Lyon","Lille","Braga","Fiorentina","Galatasaray","Fenerbahce","Besiktas"};
        public List<string> Europa_above_low = new List<string>()
        {"Union Berlin","SC Freiburg","Celtic","Rangers","Trabzonspor","Istanbul Basaksehir","Olympiakos","PAOK Salonika","Zenith","Spartak M","CSKA","Krasnodar"};
        public List<string> Europa_LOW = new List<string>()
        {"Wolverhampton","Crystal Palace","Leeds","Celta Vigo","Osasuna","Getafe","Wolfsburg","Borussia Monchengladbach","Sassuolo","Stade Rennais","Nice","Lens","Stade de Reims","Panathinaikos","AEK Athens","Aris"};

        public List<string> Amerikan = new List<string>()
        {"Palmeiras","Flamengo","Internacional","Fluminense","Corinthians","São Paulo","River Plate","Boca Juniors","Racing Club","LA Galaxy","Atlanta United","New York City","Inter Miami","Toronto"};

        public List<string> Money_FC = new List<string>()
        {"Al Nassr","Al Hilal","LA Galaxy","New York City","Toronto"};

        //линии игры вашего игрока
        public List<string> Positian = new List<string>()
        {
            "НАП","ПЗ","ЗЩ"
        };

        Random random = new Random();
        //переменная для условий
        public int number {  get; set; }
        public int answer { get; set; }
        //переменные
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public string FC { get; set; }
        public int height { get; set; }
        public double weight { get; set; }
        public double rating { get; set; }
        public int goal_pass { get; set; }
        public int popularity { get; set; }
        public int successful_actions_in_attack { get; set; }
        public int successful_actions_in_defens { get; set; }
        public int matches_played { get; set; }
        //сумма за карьеру
        public int sum_g_p { get; set; }
        public int sum_matches {get; set; }
        //отношенеие 
        public int training_evaluation { get; set; }
        public int training_popularity { get; set; }

        public void introduction()//Введение
        {
            Console.Write("{0,75}", "Добро пожаловать Non-Standard Soccer");

            Console.WriteLine("\nВ данной \"ИГРЕ\" вас будет ждать карьера за игрока в которой вам предстоит, стать популярным и высокорейтиноговым игроком либо же закончить путь становления таким, неуспев добиться чего-либо." +
                " Вы находитесь в начале своего пути после окончания молодёжной академии, вам 16 лет и предстоит долгий или же короткий путь");
            Console.ReadKey();
        }
        public void Data_processing()
        { 
            Console.WriteLine("\nВ какой линии во времена молодежки вы были более эфф. " +
                "\n 1-я Защитник" +
                "\n 2-я Полузащитник" +
                "\n 3-я Нападающий");
            number = Convert.ToInt32(Console.ReadLine());
            while (number == 1)
            {
                Position = Positian[2];
                Console.WriteLine("Ага значит: "+ Position);
                break;
            }
            while (number == 2)
            {
                Position = Positian[1];
                Console.WriteLine("Ага значит: "+ Position);
                break;
            }
            while (number == 3)
            {
                Position = Positian[0];
                Console.WriteLine("Ага значит: " + Position);
                break;
            }
            while (number >= 4)
            {
                Console.WriteLine("Не не давай еще раз");
                Data_processing();
            }
            Age = 16;
            Console.WriteLine("\nДавайте вас измерим и узнаем какой у вас рост =");
            height = Convert.ToInt32(Console.ReadLine());
            while (height > 215 | height < 155)
            {
                Console.WriteLine("ВОУ ВОУ ну ты и дылда, ты помойму что-то перепутал, давай-ка ты лучше иди в баскетбол, СЛЕДУЮЩИЙ");
                Data_processing();
            }
            Console.WriteLine("Давайте взвесим вас и узнаем ваш вес =");
            weight = Convert.ToDouble(Console.ReadLine());
            while (weight > 100 | weight < 60)
            {
                Console.WriteLine("ВОУ ВОУ ну у тебя и масса, извиняй конечно, но мы тут не фитнес центр, СЛЕДУЮЩИЙ");
                Data_processing();
            }
            Console.WriteLine("А и на помните пожалуйста вашу фамилию :");
            Lastname = Console.ReadLine();

            Console.WriteLine("Мы добавили тебя и твои данны в бд, теперь подождем пока тобой кто-нибудь заинтересуется");
            
            Console.ReadKey();

            Console.WriteLine("Тобой заинтересовалось несколько клубов из РПЛ");
            Console.WriteLine("В данный момент с этими клубами ведет переговоры твой агент, он постарается выбить самые лучшие условия для тебя.");
            Console.ReadKey();

            int index = random.Next(RPL.Count);
            Console.WriteLine($"Тебя подписал один из клубов РПЛ");
            FC = Convert.ToString(RPL[index]);
            Console.WriteLine(FC);
            Console.ReadKey();

            Console.WriteLine("А теперь они оценят твой рейтинг по методам FIFA, который ты узнаешь чуть позже");
            rating = random.Next(64, 67);
            Console.Write($"\"{rating}\"");

            Console.ReadKey();
            
            Console.WriteLine("Ты выходец не из самой престижной молодежной академии, и поэтому ты не так популярен как тебе наверное хотелось, но все еще впереди.");
            popularity = random.Next(1500, 5400);
            Console.ReadKey();

            Console.WriteLine("'Подсказка:' В каждом сезоне у тебя будет 4-ре ключевых матчей в которых тебе предстоит выбрать один из возможных вариантов." +
                "Что касается остальных матчей в сезоне то они будут проходить и наращивать тебе статистику основываясь на твоих навыках и отношении.");

        }


        public void training_OVR() //повышение FIFA OVR
        {
            Console.WriteLine("\nЗдесь вам определиться с вашим отношение к тренировкам. Вы это решаете сами для себя, каждый новый сезон:" +
                "\n 1-Лениво" +
                "\n 2-Проффесианально" +
                "\n 3-Трудоголик" +
                "\n Также это будет влиять на вашу частоту игры (ленитесь мало играете и наоборот)");
            training_evaluation = Convert.ToInt32(Console.ReadLine());
            switch (training_evaluation)
            {
                case 1:
                    rating -= random.Next(1,2);
                    break;
                case 2:
                    rating += random.Next(1,2);
                    break;
                case 3:
                    rating += random.Next(2,3);
                    break;
                default:
                    training_OVR();
                    break;
            }
            Console.ReadKey();
        }
        public void increasing_popularity() //медийность повышение или понижение
        {
            Console.WriteLine("Здесь вы будете уделять внимание своей медийности,каждый новый сезон" +
                "\n 1-Редко постить что-либо" +
                "\n 2-Один пост в неделю" +
                "\n 3-Несколько постов в неделю + курсы пиара");
            training_popularity = Convert.ToInt32(Console.ReadLine());
            switch (training_popularity)
            {
                case 1:
                    popularity -= random.Next(0, 700);
                    break;
                case 2:
                    popularity += random.Next(400, 1500);
                    break;
                case 3:
                    popularity += random.Next(2000, 5000);
                    break;
                default:
                    increasing_popularity();
                    break;
            }
        }
        public void Matches_in_Season() //здесь будет определяться кол-во сколько матчей в сезоне вы сыграете
        {
            switch (training_evaluation)
            {
                case 1:
                    matches_played = random.Next(1,10);
                    break;
                case 2:
                    matches_played = random.Next(12,25);
                    break;
                case 3:
                    matches_played = random.Next(26,40);
                    break;
                    default:
                    training_OVR();
                    break;
            }
            Console.ReadKey();
        }
        public void Generation_goalpass_successfulactions() //считывания статиски основанной на матчах и линии игры
        { 
            if(number == 3)
            {
                if (matches_played >= 32)
                {
                    goal_pass = random.Next(35,54);
                    successful_actions_in_attack = random.Next(40,70);
                }
                if (matches_played <= 28 | matches_played >= 15)
                {
                    goal_pass = random.Next(20,32);
                    successful_actions_in_attack = random.Next(22, 39);
                }
                if (matches_played <= 12)
                {
                    goal_pass = random.Next(1,17);
                    successful_actions_in_attack = random.Next(10, 24);
                }
            }
            if (number == 2)
            {
                if (matches_played >= 32)
                {
                    goal_pass = random.Next(27, 40);
                    successful_actions_in_attack = random.Next(10, 24);
                    successful_actions_in_defens = random.Next(15, 30);
                }
                if (matches_played <= 28 | matches_played >= 15)
                {
                    goal_pass = random.Next(18, 24);
                    successful_actions_in_attack = random.Next(9, 18);
                    successful_actions_in_defens = random.Next(12, 22);
                }
                if (matches_played <= 12)
                {
                    goal_pass = random.Next(1, 24);
                    successful_actions_in_attack = random.Next(6, 11);
                    successful_actions_in_defens = random.Next(5, 15);
                }
            }
            if (number == 1)
            {
                if (matches_played >= 32)
                {
                    goal_pass = random.Next(10,15);
                    successful_actions_in_defens = random.Next(40,70);
                }
                if (matches_played <= 28 | matches_played >= 15)
                {
                    goal_pass = random.Next(6, 11);
                    successful_actions_in_defens = random.Next(20, 39);
                }
                if (matches_played <= 12)
                {
                    goal_pass = random.Next(0, 9);
                    successful_actions_in_defens = random.Next(3, 15);
                }
            }
            Console.ReadKey();
        }
        
        public void Summ_all()//сумм матчей и очкнов по гол+пас за карьеру
        {
            sum_g_p += goal_pass;
            sum_matches += matches_played;
        }

        //ключевые матчи сезона
        public void Matches_1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0,75}", "Это 1-й ключевой матс в сезоне");
            Console.ForegroundColor = ConsoleColor.White;
            if (number == 1) 
            {
                int truenumber = random.Next(1,3); //диапозон зависит от количества вариантов решения момента
                Console.WriteLine("Вам престоит приянть решение в моменте на поле, которое отразиться на вас");
                Console.WriteLine("\nВы находитесь на краю вашей штрафной, игрок соперника смещается с фланга в центр, при это к воротам на навес бегут и др. игроки его команды, " +
                    "какие будут ваши действия" +
                    "\n1-е Занять позицию для блокировки удара в дальний угол" +
                    "\n2-е Заблокировать любой пас или навес в вашу штрафную" +
                    "\n3-е Пойти в отбор");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == truenumber)
                {
                    successful_actions_in_defens += 1;
                    popularity += random.Next(100,300);
                    Console.WriteLine("\"Болельщики\" скандируют вашу фамилию");
                }
                else
                {
                    popularity -= random.Next(250, 500);
                    Console.WriteLine("\"Болельщики\" освистываеют вас и негадают");
                }
            }
            if (number == 2) 
            {
                int truenumber = random.Next(1,3); //диапозон зависит от количества вариантов решения момента
                Console.WriteLine("Вам престоит приянть решение в моменте на поле, которое отразиться на вас");
                Console.WriteLine("\nВы открылись и получили мяч на левом фланге полузащиты, что будите делать дальше" +
                    "\n1-е Пойти по этому флангу и затем навесить в штрафную" +
                    "\n2-е Продвигать мяч на дриблинге до штрафной а там отпасовать/навесить в штрафную" +
                    "\n3-е На скорости и дриблинге добраться до штрафной выйти на ударную позицию и пробить");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == truenumber)
                {
                    goal_pass += 1;
                    successful_actions_in_attack += 1;
                    popularity += random.Next(200, 400);
                    Console.WriteLine("\"Болельщики\" скандируют вашу фамилию");
                }
                else
                {
                    popularity -= random.Next(250, 500);
                    Console.WriteLine("\"Болельщики\" освистываеют вас и негадают");
                }
            }
            if (number == 3)
            {
                int truenumber = random.Next(1,3); //диапозон зависит от количества вариантов решения момента
                Console.WriteLine("Вам престоит приянть решение в моменте на поле, которое отразиться на вас");
                Console.WriteLine("\nВы оказались на у штрафной соперника, до ворот 23 метра, перед вами 1 защитник оставшиеся пытаються закрыть ваших партнеров открывающихся в штрафной или около, ваши действия" +
                    "\n1-е Обвести защитника, чуток приблизиться к воротам и пробить по ним" +
                    "\n2-е Обвести защитника сместья под удар сделать ложной удар и прострельную передачу на партнера вблизи ворот" +
                    "\n3-е Раскачать заща, сместься на не ударную позицию и с разворота отдать передачу на набегающего в штрафную партнера");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == truenumber)
                {
                    goal_pass += 1;
                    successful_actions_in_attack += 1;
                    popularity += random.Next(250, 450);
                    Console.WriteLine("\"Болельщики\" скандируют вашу фамилию");
                }
                else
                {
                    popularity -= random.Next(350, 500);
                    Console.WriteLine("\"Болельщики\" освистываеют вас и негадают");
                }
            }
            if (number >= 4)
            {
                popularity -= random.Next(350, 500);
                Console.WriteLine("Ваше попыта импровазации не удалась");
            }
            matches_played += 1;
            Console.ReadKey();
        }
        
        public void Matches_2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0,75}", "Это 2-й ключевой матс в сезоне");
            Console.ForegroundColor = ConsoleColor.White;
            if (number == 1)
            {
                int truenumber = random.Next(1,3); //диапозон зависит от количества вариантов решения момента
                Console.WriteLine("Вам престоит приянть решение в моменте на поле, которое отразиться на вас");
                Console.WriteLine("\nВы на линии штрафной на своей половине поле, ситуация 2 в 3 вас в меньшенстве, ваш сокомандник успевает накрыть только одного," +
                    "\n1-е Оставться между ними до последнего минимизирую все варианты но не до конца" +
                    "\n2-е Сделать вид что идете в отбор, но потом на перехват или же пресинг ко второму если будет пас" +
                    "\n3-е Сместиться к воторотам и быть готовым отражать мяч любой частью тела");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == truenumber)
                {
                    successful_actions_in_defens += 1;
                    popularity += random.Next(100, 300);
                    Console.WriteLine("\"Болельщики\" скандируют вашу фамилию");
                }
                else
                {
                    popularity -= random.Next(250, 500);
                    Console.WriteLine("\"Болельщики\" освистываеют вас и негадают");
                }
            }
            if (number == 2)
            {
                int truenumber = random.Next(1,3); //диапозон зависит от количества вариантов решения момента
                Console.WriteLine("Вам престоит приянть решение в моменте на поле, которое отразиться на вас");
                Console.WriteLine("\nВы в моменте контрАтаки ваши НАПы 3 в 2, полузащита противника идет вас пресинговать" +
                    "\n1-е Закинуть мяч на одного из ваших вингеров и бежать к линии штрафной" +
                    "\n2-е Отдать пас на форварда, попросить назад а затем пустить мяч за спину сместившегося защитника" +
                    "\n3-е По бежать к штрафной, обыграть защитника если придется, и пока НАПы отвлекают оставшихся ЗАЩ пробиться по воротам самостоятельно");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == truenumber)
                {
                    goal_pass += 1;
                    successful_actions_in_attack += 1;
                    popularity += random.Next(200, 400);
                    Console.WriteLine("\"Болельщики\" скандируют вашу фамилию");
                }
                else
                {
                    popularity -= random.Next(250, 500);
                    Console.WriteLine("\"Болельщики\" освистываеют вас и негадают");
                }
            }
            if (number == 3)
            {
                int truenumber = random.Next(1,3); //диапозон зависит от количества вариантов решения момента
                Console.WriteLine("Вам престоит приянть решение в моменте на поле, которое отразиться на вас");
                Console.WriteLine("\nУ вашей команды угловой на табло ничья," +
                    "\n1-е Встать на углу вратарской и попытаться забить в ближней" +
                    "\n2-е Выйти за пределы штрафной около линии и попросить навес что бы пробить в касание" +
                    "\n3-е Выйти из эпицентра игроков и попытаться забить после подбора если удастся");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == truenumber)
                {
                    goal_pass += 1;
                    successful_actions_in_attack += 1;
                    popularity += random.Next(250, 450);
                    Console.WriteLine("\"Болельщики\" скандируют вашу фамилию");
                }
                else
                {
                    popularity -= random.Next(350, 500);
                    Console.WriteLine("\"Болельщики\" освистываеют вас и негадают");
                }
            }
            if (number >= 4)
            {
                popularity -= random.Next(350, 500);
                Console.WriteLine("Ваше попыта импровазации не удалась");
            }
            matches_played += 1;
            Console.ReadKey();
        }
        
        public void Matches_3()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0,75}", "Это 3-й ключевой матс в сезоне");
            Console.ForegroundColor = ConsoleColor.White;
            if (number == 1)
            {
                int truenumber = random.Next(1,3); //диапозон зависит от количества вариантов решения момента
                Console.WriteLine("Вам престоит приянть решение в моменте на поле, которое отразиться на вас");
                Console.WriteLine("\nУгловой в ваши для команды соперника" +
                    "\n1-е Закрыть игрока на ближнем углу" +
                    "\n2-е Оказаться по середине и действовать по ситуации" +
                    "\n3-е Не закрывать ближнего но быть с ним на одном уровне и приготовиться для быстрого подбора мяча в контрАтаку");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == truenumber)
                {
                    successful_actions_in_defens += 1;
                    popularity += random.Next(100, 300);
                    Console.WriteLine("\"Болельщики\" скандируют вашу фамилию");
                }
                else
                {
                    popularity -= random.Next(250, 500);
                    Console.WriteLine("\"Болельщики\" освистываеют вас и негадают");
                }
            }
            if (number == 2)
            {
                int truenumber = random.Next(1,3); //диапозон зависит от количества вариантов решения момента
                Console.WriteLine("Вам престоит приянть решение в моменте на поле, которое отразиться на вас");
                Console.WriteLine("\nВы находитесь на углу вратарской вас бежет накрывать ЗАЩ с цента защиты, ваш партнер забегает в штрафную" +
                    "\n1-е Сделать разрезной пас на него" +
                    "\n2-е Сместиться, обвести сместиться еще сильнее и пробить" +
                    "\n3-е С угла пробить шведой в дальний");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == truenumber)
                {
                    goal_pass += 1;
                    successful_actions_in_attack += 1;
                    popularity += random.Next(200, 400);
                    Console.WriteLine("\"Болельщики\" скандируют вашу фамилию");
                }
                else
                {
                    popularity -= random.Next(250, 500);
                    Console.WriteLine("\"Болельщики\" освистываеют вас и негадают");
                }
            }
            if (number == 3)
            {
                int truenumber = random.Next(1,3); //диапозон зависит от количества вариантов решения момента
                Console.WriteLine("Вы выходите с ЗАЩ перед штрафной 1 на 1 до него метров 8");
                Console.WriteLine("\n" +
                    "\n1-е Обвести и пробить пока киперне вышел" +
                    "\n2-е Раскачать и в противоположную сторону пробросить мяч и если выйдет кипер перекинуть его если нет то пробить сильный низом" +
                    "\n3-е Пробить с закруткой вокруг ЗАЩитника в девятку");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == truenumber)
                {
                    goal_pass += 1;
                    successful_actions_in_attack += 1;
                    popularity += random.Next(250, 450);
                    Console.WriteLine("\"Болельщики\" скандируют вашу фамилию");
                }
                else
                {
                    popularity -= random.Next(350, 500);
                    Console.WriteLine("\"Болельщики\" освистываеют вас и негадают");
                }
            }
            if (number >= 4)
            {
                popularity -= random.Next(350, 500);
                Console.WriteLine("Ваше попыта импровазации не удалась");
            }
            matches_played += 1;
            Console.ReadKey();
        }
        
        public void Matches_4()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0,75}", "Это 4-й ключевой матс в сезоне");
            Console.ForegroundColor = ConsoleColor.White;
            if (number == 1)
            {
                int truenumber = random.Next(1,3); //диапозон зависит от количества вариантов решения момента
                Console.WriteLine("Вам престоит приянть решение в моменте на поле, которое отразиться на вас");
                Console.WriteLine("\nВаша защита упустила вингера" +
                    "\n1-е Молиться что кипер отобьет" +
                    "\n2-е Пойти в подкат" +
                    "\n3-е Попытаться  догнать и отобрать мяч без фола");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == truenumber)
                {
                    successful_actions_in_defens += 1;
                    popularity += random.Next(100, 300);
                    Console.WriteLine("\"Болельщики\" скандируют вашу фамилию");
                }
                else
                {
                    popularity -= random.Next(250, 500);
                    Console.WriteLine("\"Болельщики\" освистываеют вас и негадают");
                }
            }
            if (number == 2)
            {
                int truenumber = random.Next(1,3); //диапозон зависит от количества вариантов решения момента
                Console.WriteLine("Вам престоит приянть решение в моменте на поле, которое отразиться на вас");
                Console.WriteLine("\nВы получаете мяч с отскока, до ворот 26,5 метро, ваши НАПы и ЗАЩита противника в равных условиях" +
                    "\n1-е Пробить дальний" +
                    "\n2-е Отыграть в стеночку а затем пробить/отпосоввать" +
                    "\n3-е Попытаться прорваться самому и в последний момент отдать пас НАПу");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == truenumber)
                {
                    goal_pass += 1;
                    successful_actions_in_attack += 1;
                    popularity += random.Next(200, 400);
                    Console.WriteLine("\"Болельщики\" скандируют вашу фамилию");
                }
                else
                {
                    popularity -= random.Next(250, 500);
                    Console.WriteLine("\"Болельщики\" освистываеют вас и негадают");
                }
            }
            if (number == 3)
            {
                int truenumber = random.Next(1,3); //диапозон зависит от количества вариантов решения момента
                Console.WriteLine("Вы выходите с ЗАЩ перед штрафной 1 на 1 до него метров 8");
                Console.WriteLine("\nСудься поставил пенальте в ворота соперника, вы бьете" +
                    "\n1-е Пробить на силу" +
                    "\n2-е Пробить на технику" +
                    "\n3-е Отдать пас на забегающего партнера");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == truenumber)
                {
                    goal_pass += 1;
                    successful_actions_in_attack += 1;
                    popularity += random.Next(250, 450);
                    Console.WriteLine("\"Болельщики\" скандируют вашу фамилию");
                }
                else
                {
                    popularity -= random.Next(350, 500);
                    Console.WriteLine("\"Болельщики\" освистываеют вас и негадают");
                }
            }
            if (number >= 4)
            {
                popularity -= random.Next(350, 500);
                Console.WriteLine("Ваше попыта импровазации не удалась");
            }
            matches_played += 1;
            Console.ReadKey();
        }

        //методы генерации клубов для трансферов
        public void Transfer_EuropaTop()
        {
            if (rating >= 86)
            {
                int index = random.Next(EuropaTop.Count);
                Console.WriteLine($"Тебя подписал один из Топ клубов");
                FC = Convert.ToString(EuropaTop[index]);
            }
            else
            {
                Transfer_Europa_above_average();
            }
            Console.ReadKey();
        }
        public void Transfer_Europa_above_average() 
        {
            if ( rating >= 81)
            {
                int index = random.Next(Europa_above_average.Count);
                Console.WriteLine($"Тебя подписал один из ПредТоп клубов");
                FC = Convert.ToString(Europa_above_average[index]);
            }
            else
            {
                Transfer_Europa_medium();
            }
            Console.ReadKey();
        }
        public void Transfer_Europa_medium()
        {
            if ( rating >= 80)
            {
                int index = random.Next(Europa_medium.Count);
                Console.WriteLine($"Тебя подписал один из Крепких средняков Евпропы");
                FC = Convert.ToString(Europa_medium[index]);
            }
            else
            {
                Transfer_Europa_below_average();
            }
            Console.ReadKey();
        }
        public void Transfer_Europa_below_average()
        {
            if ( rating >= 78)
            {
                int index = random.Next(Europa_below_average.Count);
                Console.WriteLine($"Тебя подписал один из среднячков Евпропы");
                FC = Convert.ToString(Europa_below_average[index]);
            }
            else
            {
                Transfer_Europa_above_low();
            }
            Console.ReadKey();
        }
        public void Transfer_Europa_above_low()
        {
            if (rating >= 75)
            {
                int index = random.Next(Europa_above_low.Count);
                Console.WriteLine($"Тебя подписал один из известных ФК но не сильныхЕвпропы");
                FC = Convert.ToString(Europa_above_low[index]);
            }
            else
            {
                Transfer_Europa_LOW();
            }
            Console.ReadKey();
        }
        public void Transfer_Europa_LOW()
        {
            if (rating >= 72)
            {
                int index = random.Next(Europa_LOW.Count);
                Console.WriteLine($"Тебя подписал один из малоизвестный клубов Евпропы");
                FC = Convert.ToString(Europa_LOW[index]);
            }
            else
            {
                int index = random.Next(RPL.Count);
                Console.WriteLine($"Тебя подписал один из клубов РПЛ");
                FC = Convert.ToString(RPL[index]);
            }
            Console.ReadKey();
        }
        public void Transfer_Amerikan()
        {
                int index = random.Next(Amerikan.Count);
                Console.WriteLine($"Тебя подписал один из ФК Американского континента");
                FC = Convert.ToString(Amerikan[index]);
            Console.ReadKey();
        }
        public void Transfer_Money()
        {
            int index = random.Next(Money_FC.Count);
            Console.WriteLine($"Прощай топ чемпионата, вас подписал ФК Мешок");
            FC = Convert.ToString(Money_FC[index]);
            Console.ReadKey();
        }


        public void Transfer_to_club()//переход в др. клуб
        {
            Console.WriteLine("Хотите ли вы сменить клуб?" +
                "\n1-e Да" +
                "\n2-е нет");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 1) 
            {
                Console.WriteLine("В какой клуб вы хотите перейти" +
                    "\n 1-е Европейский топ" +
                    "\n 2-е Европейски предТоп" +
                    "\n 3-е Европейский крепкий средняк" +
                    "\n 4-е Европейский среднячок" +
                    "\n 5-е Европейский известный, не конкурентный ФК" +
                    "\n 6-е Европейский малоизвестный ФК" +
                    "\n 7-е Доигровать за Океан" +
                    "\n 8-е Идити на заработи" );
                answer = Convert.ToInt32(Console.ReadLine());
                switch (answer) 
                { 
                    case 1:
                        Transfer_EuropaTop();
                        break;
                    case 2:
                        Transfer_Europa_above_average();
                        break;
                    case 3:
                        Transfer_Europa_medium();
                        break;
                    case 4:
                        Transfer_Europa_below_average();
                        break;
                    case 5:
                        Transfer_Europa_above_low();
                        break;
                    case 6:
                        Transfer_Europa_LOW();
                        break;
                    case 7:
                        Transfer_Amerikan();
                        break;
                    case 8:
                        Transfer_Money();
                        break;
                }
            }
            if (number == 2) 
            {
                Console.WriteLine("Вы остались в том же клубе");
            }
        }

        public void You_Dannie()//вывод данных о вас
        {
            Console.WriteLine($"\nФамилия :{Lastname}");
            Console.WriteLine($"Возраст :{Age}");
            Console.WriteLine($"Рост см.={height}");
            Console.WriteLine($"Вес кг.={weight}");
            Console.WriteLine($"Линия игры:{Position}");
            Console.WriteLine($"Твой клуб:{FC}");
            Console.WriteLine($"Рейтинг FIFA ={rating}");
            Console.WriteLine($"Кол. подписчиков ={popularity}");
            Console.WriteLine($"Матчей в сезоне ={matches_played}");
            Console.WriteLine($"Очков по системе гол+пас ={goal_pass}");
            Console.WriteLine($"Очков по гол+пас за всю карьеру ={sum_g_p}");
            Console.WriteLine($"Сыграно матчей за всю карьеру ={sum_matches}");
            Console.WriteLine($"Кол. успешных действий в обороне ={successful_actions_in_defens}");
            Console.WriteLine($"Кол. успешных действий в атаке ={successful_actions_in_attack}");
            Console.ReadKey();
        }
        
        public void Head()//Карьера
        {
            introduction();
            Data_processing();
           for (int i = 0; i < 20; i++) 
           { 
                if (Age >= 35)
                {
                    if (rating >=84)
                    {
                        Console.WriteLine("Вы провели замечательную карьеру топ футболиста мира,которого будут помнить спустя поколения");
                        You_Dannie();
                        break;
                    }
                    if (rating <= 83 | rating >= 78)
                    {
                        Console.WriteLine("Вы провели карьеру близкую к уровню звездного футболиста, ваши фанаты клубо, сборной и страны вас будут помнить");
                        You_Dannie();
                        break;
                    }
                    if (rating <=75)
                    {
                        Console.WriteLine("У вас была карьера не прммечательного футболиста который не смог достичь чего то высокого.");
                        You_Dannie();
                        break;
                    }
                }
                training_OVR();
                increasing_popularity();
                Matches_in_Season();
                Generation_goalpass_successfulactions();
                Matches_1();
                Matches_2();
                Matches_3();
                Matches_4();
                Transfer_to_club();
                Summ_all();
                Age += 1;
                You_Dannie();
                Console.WriteLine("{0,75}", "\nВот и закончился сезон, да будет новый сезон успешнее старого");
                Console.ReadKey();
            }
        }
    }
}