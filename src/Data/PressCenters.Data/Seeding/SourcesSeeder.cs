﻿namespace PressCenters.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PressCenters.Data.Models;

    public class SourcesSeeder : ISeeder
    {
        public void Seed(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var sources = new List<(string TypeName, string ShortName, string Name, string Description, string Url)>
                          {
                              ("PressCenters.Services.Sources.Ministries.MvrBgSource",
                                  "МВР", "Министерство на вътрешните работи",
                                  "Министерството на вътрешните работи (МВР) е българска държавна институция с ранг на министерство, която се грижи за защитата на националната сигурност, борбата с престъпността, опазването на обществения ред и други.",
                                  "https://www.mvr.bg/"),
                              ("PressCenters.Services.Sources.Ministries.MhGovernmentBgNewsSource",
                                  "МЗ", "Министерство на здравеопазването - Новини",
                                  "Чрез Министерството на здравеопазването българската държава гарантира опазването здравето на гражданите и прилага принципи на равнопоставеност при ползване на здравни услуги.",
                                  "https://www.mh.government.bg/bg/novini/aktualno/"),
                              ("PressCenters.Services.Sources.Ministries.MhGovernmentBgEpidemicSource",
                                  "МЗ", "Министерство на здравеопазването - Епидемична обстановка",
                                  "Чрез Министерството на здравеопазването българската държава гарантира опазването здравето на гражданите и прилага принципи на равнопоставеност при ползване на здравни услуги.",
                                  "https://www.mh.government.bg/bg/novini/epidemichna-obstanovka/"),
                              ("PressCenters.Services.Sources.Ministries.MhGovernmentBgMinisterskiSuvetSource",
                                  "МЗ", "Министерство на здравеопазването - Министерски съвет",
                                  "Чрез Министерството на здравеопазването българската държава гарантира опазването здравето на гражданите и прилага принципи на равнопоставеност при ползване на здравни услуги.",
                                  "https://www.mh.government.bg/bg/novini/ministerski-savet/"),
                              ("PressCenters.Services.Sources.Ministries.MhGovernmentBgParlamentarenKontrolSource",
                                  "МЗ", "Министерство на здравеопазването - Парламентарен контрол",
                                  "Чрез Министерството на здравеопазването българската държава гарантира опазването здравето на гражданите и прилага принципи на равнопоставеност при ползване на здравни услуги.",
                                  "https://www.mh.government.bg/bg/novini/parlamentaren-kontrol/"),
                              ("PressCenters.Services.Sources.Ministries.MrrbBgSource",
                                  "МРРБ", "Министерство на регионалното развитие и благоустройството",
                                  "Министерството на регионалното развитие и благоустройството е отговорно за провеждане на реформата в регионалното развитие на страната, устройството на територията, изграждането на основните мрежи и съоръжения на техническата инфраструктура.",
                                  "https://www.mrrb.bg/"),
                              ("PressCenters.Services.Sources.Ministries.MonBgSource",
                                  "МОН", "Министерство на образованието и науката",
                                  "Министерството на образованието и науката управлява и упражнява надзора върху учебно-възпитателните, културните и просветните инстанции в страната.",
                                  "https://www.mon.bg/"),
                              ("PressCenters.Services.Sources.Ministries.MfaBgSource",
                                  "МВнР", "Министерство на външните работи",
                                  "Министерството на външните работи ръководи, координира и контролира осъществяването на държавната политика на Република България в отношенията й с други държави, като осигурява поддържането и развитието на външнополитическия диалог, политиката на сигурност и двустранното, регионалното и многостранното сътрудничеството. Осъществява общата координация в областта на външната политика и международната дейност на Република България.",
                                  "https://www.mfa.bg/"),
                              ("PressCenters.Services.Sources.Ministries.MlspBgSource",
                                  "МТСП", "Министерство на труда и социалната политика",
                                  "Министерство на труда и социалната политика (МТСП) е българска държавна институция с ранг на министерство, която урежда повишаването на качеството и сигурността на труда чрез защитата на трудовите, осигурителните и социалните права на работниците и служителите и подобряването на условията на труд в предприятията, провежда държавната политика в областта на пазара на труда, защитата на националния пазар на труда, обучението на работната сила и интеграцията на неравнопоставените групи на пазара на труда.",
                                  "https://www.mlsp.government.bg/"),
                              ("PressCenters.Services.Sources.Ministries.MzhGovernmentBgSource",
                                  "МЗХГ", "Министерство на земеделието, храните и горите",
                                  "Министерството на земеделието, храните и горите е администрация, която подпомага министъра на земеделието, храните и горите при осъществяване на правомощията му, осигурява технически дейността му и извършва дейности по административното обслужване на гражданите и юридическите лица.",
                                  "http://www.mzh.government.bg/"),
                              ("PressCenters.Services.Sources.Ministries.MinFinBgSource",
                                  "МФ", "Министерство на финансите",
                                  "Министерството на финансите е българската институция, отговорна за разработването, координирането и контрола при осъществяването на държавната политика в областите публични финанси, данъчна политика, управление на държавния дълг, финансови услуги и финансови пазари, вътрешен контрол.",
                                  "https://www.minfin.bg/"),
                              ("PressCenters.Services.Sources.Ministries.MiGovernmentBgSource",
                                  "МИ", "Министерство на икономиката",
                                  "Министерството на икономиката (МИ) е българска държавна институция с ранг на министерство.",
                                  "https://www.mi.government.bg/"),
                              ("PressCenters.Services.Sources.Ministries.McGovernmentBgSource",
                                  "МК", "Министерство на културата",
                                  "Министерството на културата (МК) е българска държавна институция с ранг на министерство. Под негова юрисдикция са паметниците на културата, музеите, историческите забележителности, театрите, операта, балетът и някои средни училища с национално значение.",
                                  "http://www.mc.government.bg/"),
                              ("PressCenters.Services.Sources.Ministries.TourismGovernmentBgSource",
                                  "МТ", "Министерство на туризма",
                                  "Министерството на туризма (МТ) провежда политиката в туризма в условията на публичност, откритост, активен диалог и сътрудничество с институциите, общинските администрации, неправителствените организации, бизнеса и медиите. Основен приоритет е да се осъществява законосъобразно и целесъобразно туристическата политика на страната, да се създадат необходимите условия за развитие на диверсифициран национален туристически продукт, който да бъде промотиран на нашия и чуждите туристически пазари.",
                                  "http://www.tourism.government.bg/"),
                              ("PressCenters.Services.Sources.Ministries.MtitcGovernmentBgSource",
                                  "МТИТС", "Министерство на транспорта, информационните технологии и съобщенията",
                                  "Министерството на транспорта, информационните технологии и съобщенията (МТИТС) е министерство в България, което провежда правителствената политика в областта на транспорта, информационните технологии и съобщенията.",
                                  "https://www.mtitc.government.bg/"),
                              ("PressCenters.Services.Sources.Ministries.MoewGovernmentBgNationalNewsSource",
                                  "МОСВ", "Министерство на околната среда и водите - Национални новини",
                                  "Министерството на околната среда и водите разработва и провежда държавната политика в областта на околната среда, като основните й аспекти са свързани със: законодателна инициатива, стратегическо планиране, изпълнение на секторните политики, упражняване на превантивна дейности и управление на програми и проекти.",
                                  "https://www.moew.government.bg/"),
                              ("PressCenters.Services.Sources.Ministries.MoewGovernmentBgRegionalNewsSource",
                                  "МОСВ", "Министерство на околната среда и водите - Регионални новини",
                                  "Министерството на околната среда и водите разработва и провежда държавната политика в областта на околната среда, като основните й аспекти са свързани със: законодателна инициатива, стратегическо планиране, изпълнение на секторните политики, упражняване на превантивна дейности и управление на програми и проекти.",
                                  "https://www.moew.government.bg/"),
                              ("PressCenters.Services.Sources.Ministries.MeGovernmentBgNewsSource",
                                  "МЕ", "Министерство на енергетиката - Новини",
                                  "Министерството на енергетиката (МЕ) има основни задачи по проектиране, научноизследователска дейност, поддържане и експлоатация на енергийните съоръжения на територията на страната, производство и пренос на топлинна и електрическа енергия, добив и преработка на рудни и нерудни изкопаеми, използване на водните ресурси за добив на ток и други.",
                                  "https://www.me.government.bg/bg/news.html"),
                              ("PressCenters.Services.Sources.Ministries.MeGovernmentBgHotNewsSource",
                                  "МЕ", "Министерство на енергетиката - Акценти",
                                  "Министерството на енергетиката (МЕ) има основни задачи по проектиране, научноизследователска дейност, поддържане и експлоатация на енергийните съоръжения на територията на страната, производство и пренос на топлинна и електрическа енергия, добив и преработка на рудни и нерудни изкопаеми, използване на водните ресурси за добив на ток и други.",
                                  "https://www.me.government.bg/bg/hot-news.html"),
                              ("PressCenters.Services.Sources.Ministries.MjsBgSource",
                                  "МП", "Министерство на правосъдието",
                                  "Министерството на правосъдието (МП) е българска държавна институция с ранг на министерство, която осъществява връзката между изпълнителната и съдебната власт. Ръководи изработването на закони и други законови актове свързани със съдебната система и дава становища по законопроекти изработени от други органи на изпълнителната власт.",
                                  "http://www.mjs.bg/"),
                              ("PressCenters.Services.Sources.BgInstitutions.NsiBgNewsSource",
                                  "НСИ", "Национален статистически институт - Новини",
                                  "Националният статистически институт на Република България (НСИ) е държавна агенция, пряко подчинена на Министерския съвет, която се занимава с набиране, обработване и предоставяне на точна информация за цялостното социално и икономическо състояние и развитие на България.",
                                  "http://www.nsi.bg/"),
                              ("PressCenters.Services.Sources.BgInstitutions.NsiBgPressSource",
                                  "НСИ", "Национален статистически институт - Прессъобщения",
                                  "Националният статистически институт на Република България (НСИ) е държавна агенция, пряко подчинена на Министерския съвет, която се занимава с набиране, обработване и предоставяне на точна информация за цялостното социално и икономическо състояние и развитие на България.",
                                  "http://www.nsi.bg/"),
                              ("PressCenters.Services.Sources.BgInstitutions.GovernmentBgSource",
                                  "МС", "Министерски съвет",
                                  "Министерският съвет (Правителството) е основен орган на изпълнителната власт в Република България.",
                                  "http://www.government.bg/"),
                              ("PressCenters.Services.Sources.BgInstitutions.FscBgSource",
                                  "КФН", "Комисия за финансов надзор",
                                  "Комисията за финансов надзор на Република България е специализиран държавен регулаторен орган за контролиране на финансовата система, извън банковия сектор, надзорът над който се осъществява от Българската народна банка.",
                                  "http://www.fsc.bg/bg/"),
                              ("PressCenters.Services.Sources.BgInstitutions.ApiBgSource",
                                  "АПИ", "Агенция \"Пътна инфраструктура\"",
                                  "Агенция „Пътна инфраструктура“ е специализирана агенция към Министерството на регионалното развитие и благоустройството, отговаряща за републиканската пътна мрежа.",
                                  "http://www.api.bg/index.php/bg/"),
                              ("PressCenters.Services.Sources.BgInstitutions.PrbBgSource",
                                  "Прокуратурата", "Прокуратура на Република България",
                                  "Прокуратурата на Република България (ПРБ) е структура на държавното обвинение в системата на съдебната власт на Република България. ПРБ е независима част от съдебната система, отделна от съда.",
                                  "https://www.prb.bg/bg/"),
                              ("PressCenters.Services.Sources.BgInstitutions.PresidentBgSource",
                                  "Президентството", "Президентство на Република България",
                                  "Президентът на България е държавният глава на Република България, който е сред органите на държавната власт.",
                                  "https://www.president.bg/"),
                              ("PressCenters.Services.Sources.BgStateCompanies.ToploBgSource",
                                  "Топлофикация", "Топлофикация София ЕАД",
                                  "„Топлофикация София” EАД е най-старата топлофикационна система в България. По мащабите на производство и периметъра на обслужване „Топлофикация София” EАД е най-голямото дружество в страната и на Балканския полуостров.",
                                  "https://toplo.bg/"),
                              ("PressCenters.Services.Sources.BgNgos.ImeBgSource",
                                  "ИПИ", "Институт за пазарна икономика",
                                  "Институтът за пазарна икономика е официално регистриран като неправителствена организация на 15 март 1993 г. Мисията на ИПИ е да развива и защитава пазарните подходи за преодоляване на предизвикателствата, пред които гражданите на България и в региона се изправят.",
                                  "https://ime.bg/"),
                              /*("PressCenters.Services.Sources.BgPoliticalParties.GerbBgSource", "ГЕРБ", "ПП ГЕРБ",
                                  "ПП ГЕРБ е дясноцентристка консервативна политическа партия в България. Тя е основана на 3 декември 2006 година по инициатива на тогавашния кмет на София Бойко Борисов на основата на създаденото по-рано през същата година гражданско сдружение с име „Граждани за европейско развитие на България“ и абревиатура „ГЕРБ“.",
                                  "http://gerb.bg/"),*/
                              /*("PressCenters.Services.Sources.BgPoliticalParties.BspBgSource", "БСП",
                                  "Българска социалистическа партия (БСП)",
                                  "Българската социалистическа партия (БСП) е лявоцентристка социалдемократическа политическа партия в България. Член на Социалистическия интернационал от октомври 2003 г. и на Партията на европейските социалисти (ПЕС). Дейността ѝ се ръководи от Национален съвет (НС) начело с председател. Наследник на Българската комунистическа партия.",
                                  "https://bsp.bg/"),*/
                          };

            foreach (var source in sources)
            {
                if (!dbContext.Sources.Any(x => x.TypeName == source.TypeName))
                {
                    dbContext.Sources.Add(
                        new Source
                        {
                            TypeName = source.TypeName,
                            ShortName = source.ShortName,
                            Name = source.Name,
                            Description = source.Description,
                            Url = source.Url,
                        });
                }
            }
        }
    }
}
