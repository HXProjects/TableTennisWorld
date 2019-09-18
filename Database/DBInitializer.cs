using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Database
{
    internal class DBInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            IList<News> defaultNews = new List<News>();
            defaultNews.Add(new News() { Title = "Matilda Ekholm:  Day 3", Content = "Impressive Matilda Ekholm will step up to the table on the third day Sanil Shetty of India. No great disasters in recent tournaments but Matilda Ekholm is hardly tearing down walls, she needs to move up a gear if she is to match Marie Svensson; for her, over two decades ago she entered the Women’s World Cup with a degree of confidence, in 1994 in Birmingham she had been crowned European champion.", Date = new System.DateTime(2019, 07, 22), ImageLink = "https://ittf.cdnomega.com/eu/2018/09/EKHOLM-Matilda-SWE_2018EC_PRG_0974.jpg" });
            defaultNews.Add(new News()
            {
                Title = "T2 Diamond: Patrick Franziska, the man in form",
                Content = "Success just under one month ago at the European Games in Minsk; Germany was very much the nation in focus on the second day of action, Friday 19th July, at the T2 Diamond tournament in Johor Bahru." +
"Patrick Franziska maintained the form displayed at the recent Seamaster 2019 ITTF World Tour Platinum Australian Open, Han Ying delighted with her exquisite defensive skills.",
                Date = new System.DateTime(2019, 07, 19),
                ImageLink = " https://ittf.cdnomega.com/eu/2019/07/20190719_Match15_R16_LIANGjingkun_vs_FRANZISKApatrick_00316_WEBRES.jpg"
            });
            defaultNews.Add(new News() { Title = "T2 Diamond Series: Match Day 3", Content = "Impressive in her opening round encounter, former World no.1 Zhu Yuling looked even more imperious in her quarterfinal meeting with Sun Yingsha.Just 18 years old, Sun has been one of the standout names on the international stage in recent weeks with title-winning displays at the 2019 Japan Open and 2019 Korea Open. However, in this head-to-head it was Zhu who held the upper hand, powering to a commanding 4-0 victory (11-6, 11-5, 11-6, 11-8).", Date = new System.DateTime(2019, 07, 20), ImageLink = "https://ittf.cdnomega.com/eu/2019/07/DING-Ning_46I9107.jpg" });
            defaultNews.Add(new News() { Title = "Pretty in pink, coloured rubbers make debut!", Content = "Catching the eye, on more than one occasion Romania’s Bernadette Szocs has attracted the attention; responding to the occasion and guiding her country to victory in tense situations.In Johor Bahru, on Friday 19th July, at the T2 Diamond tournament, in her opening round contest facing China’s Ding Ning, she attracted the attention; not by her desire to win which was the same as always but by her racket; one side was black as per tradition, the other pink!", Date = new System.DateTime(2019, 07, 19), ImageLink = "https://ittf.cdnomega.com/eu/2019/07/20190719_Match14_R16_SZOCSbernadette_vs_DINGning-_00369_HIGHRES-2-1.jpg" });


            context.News.AddRange(defaultNews);

            IList<Events> defaultEvents = new List<Events>();
            defaultEvents.Add(new Events() { Name = "ITTF Para Japan Open, Tokyo (JPN)", Dates = "1 - 3 August", Link = "", Type = "Future" });
            defaultEvents.Add(new Events() { Name = "ITTF Africa Cup, Lagos (NGR)", Dates = "3 - 5 August", Link = "", Type = "Future" });
            defaultEvents.Add(new Events() { Name = "Pan Am Games, Lima (PER)", Dates = "4 - 10 August", Link = "", Type = "Future" });
            defaultEvents.Add(new Events() { Name = "ITTF-Oceania Junior Championships, Nuku’alofa (TGA)", Dates = "7 - 10 August", Link = "", Type = "Future" });
            defaultEvents.Add(new Events() { Name = "Seamaster 2019 ITTF Challenge Plus Nigeria Open, Lagos (NGR)", Dates = "7 - 11 August", Link = "", Type = "Future" });
            defaultEvents.Add(new Events() { Name = "2019 ITTF World Veterans Tour – Shenzhen, Shenzhen Guangming District (CHN)", Dates = "8 - 11 August", Link = "", Type = "Future" });
            defaultEvents.Add(new Events() { Name = "ITTF Junior Circuit Golden Hang Seng Hong Kong Junior & Cadet Open, Hong Kong (HKG)", Dates = "7 - 11 August", Link = "", Type = "Future" });
            defaultEvents.Add(new Events() { Name = "ITTF Para Bangkok Open, Bangkok (THA)", Dates = "8 – 10 August", Link = "", Type = "Future" });
            defaultEvents.Add(new Events() { Name = "Seamaster 2019 ITTF World Tour ASAREL Bulgaria Open, Panagyurishte (BUL)", Dates = "13 – 18 August", Link = "", Type = "Future" });
            defaultEvents.Add(new Events() { Name = "Commonwealth Table Tennis Championships, Cuttack (IND)", Dates = "17 – 22 July", Link = "", Type = "Active" });
            defaultEvents.Add(new Events() { Name = "T2 Diamond, Johor Bahru (MAS)", Dates = "18 – 21 July", Link = "", Type = "Active" });
            defaultEvents.Add(new Events() { Name = "ITTF Asian Para Championships, Taichung (TPE)", Dates = "23 – 27 July", Link = "", Type = "Active" });
            defaultEvents.Add(new Events() { Name = "Seamaster 2019 ITTF Challenge Plus Pyongyang Open, Pyongyang (PRK)", Dates = "24  – 28 July", Link = "", Type = "Active" });
            defaultEvents.Add(new Events() { Name = "30th Summer Universiade, Napoli (ITA)", Dates = "3  – 14 July", Link = "", Type = "Finished" });
            defaultEvents.Add(new Events() { Name = "Seamaster 2019 ITTF World Tour Platinum Australian Open, Geelong (AUS)", Dates = "9  – 14 July", Link = "", Type = "Finished" });
            defaultEvents.Add(new Events() { Name = "European Youth Championships, Ostrava (CZE)", Dates = "7  – 16 July", Link = "", Type = "Finished" });
            defaultEvents.Add(new Events() { Name = "Seamaster 2019 ITTF World Tour SHINHAN Korea Open, Busan (KOR)", Dates = "2  – 7 July", Link = "", Type = "Finished" });
            defaultEvents.Add(new Events() { Name = "ITTF African Para Championships, Alexandria (EGY)", Dates = "30 June – 3 July", Link = "", Type = "Finished" });

            context.Events.AddRange(defaultEvents);

            IList<Ranking> defaultRanking = new List<Ranking>();
            defaultRanking.Add(new Ranking() { Position = 1, PrevPosition = 3, Points = 14945, Player = "XU Xin", Country = "CHINA", Continent = "ASIA", CountryAlfaCode = "CHN", Gender = "Male", IttfId = 110267 });
            defaultRanking.Add(new Ranking() { Position = 2, PrevPosition = 2, Points = 14835, Player = "LIN Gaoyuan", Country = "CHINA", Continent = "ASIA", CountryAlfaCode = "CHN", Gender = "Male", IttfId = 115910 });
            defaultRanking.Add(new Ranking() { Position = 3, PrevPosition = 1, Points = 14670, Player = "FAN Zhendong", Country = "CHINA", Continent = "ASIA", CountryAlfaCode = "CHN", Gender = "Male", IttfId = 121404 });
            defaultRanking.Add(new Ranking() { Position = 4, PrevPosition = 4, Points = 13495, Player = "HARIMOTO Tomokazu", Country = "JAPAN", Continent = "ASIA", CountryAlfaCode = "JPN", Gender = "Male", IttfId = 123980 });
            defaultRanking.Add(new Ranking() { Position = 5, PrevPosition = 5, Points = 13125, Player = "MA Long", Country = "CHINA", Continent = "ASIA", CountryAlfaCode = "CHN", Gender = "Male", IttfId = 105649 });
            defaultRanking.Add(new Ranking() { Position = 6, PrevPosition = 7, Points = 12804, Player = "LIANG Jingkun", Country = "CHINA", Continent = "ASIA", CountryAlfaCode = "CHN", Gender = "Male", IttfId = 119588 });
            defaultRanking.Add(new Ranking() { Position = 7, PrevPosition = 8, Points = 12590, Player = "CALDERANO Hugo", Country = "BRAZIL", Continent = "LATIN AMERICA", CountryAlfaCode = "BRA", Gender = "Male", IttfId = 115641 });
            defaultRanking.Add(new Ranking() { Position = 8, PrevPosition = 6, Points = 12325, Player = "BOLL Timo", Country = "GERMANY", Continent = "EUROPE", CountryAlfaCode = "GER", Gender = "Male", IttfId = 101222 });
            defaultRanking.Add(new Ranking() { Position = 9, PrevPosition = 9, Points = 11595, Player = "FALCK Mattias", Country = "SWEDEN", Continent = "EUROPE", CountryAlfaCode = "CHN", Gender = "Male", IttfId = 112074 });
            context.Ranking.AddRange(defaultRanking);


            base.Seed(context);
        }

    }
}