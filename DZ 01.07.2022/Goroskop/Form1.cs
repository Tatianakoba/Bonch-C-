﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goroskop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string CreateHoro()
        {
            String[] horo = { "Не нужно торопиться. Вы добьетесь успеха, если будете действовать последовательно, избегать лишней суеты. " +
                                "Решайте самостоятельно, на чем вы сосредоточитесь сейчас, а что отложите на потом. Советы знакомых едва ли будут полезными," +
                                " а вот сбить вас с толку, к сожалению, могут.Ладить с окружающими может быть сложнее, чем обычно. Порой будет казаться, " +
                                "что они специально испытывают ваше терпение, стараются вывести из равновесия. Но если вы сохраните доброжелательность" +
                                " и чувство юмора, острых моментов и конфликтов удастся избежать.", "Сегодня будет особенно важно не поддаваться на провокации и " +
                                "сохранять доброжелательный и оптимистичный настрой," +
                                " как бы ни складывались обстоятельства. " +
                                "Скорее всего, вам придется иметь дело с людьми, к которым непросто найти подход. " +
                                "Едва ли кто-то другой смог бы справиться с этим лучше.Возможны небольшие разногласия на работе и дома," +
                                " но вы быстро поймете, как сгладить острые углы. Будет возможность порадовать близких. " +
                                "Не забудьте поделиться с ними хорошими новостями. Не исключено, что появится повод для домашнего праздника, " +
                                "и он удастся на славу.", "Действуйте быстро. Это особенно важно в первой половине дня: если не тратить время на пустяки, " +
                                "можно успеть очень многое. Вам будут помогать очень разные люди, даже те, от кого вы не ожидали ничего подобного. " +
                                "Не упустите возможность подружиться с теми, кто давно вам симпатичен. Вторая половина дня пройдет несколько спокойнее, " +
                                "но и она будет по-своему хороша. Вероятны успехи там, где требуются фантазия и творческий подход. ", "День будет довольно насыщенным." +
                                " Важно правильно расставить приоритеты, не тратить слишком много времени на пустяки. " +
                                "Возможны неудачные совпадения, какие-то досадные происшествия, мелкие проблемы, с решением которых вам нужно будет справиться самостоятельно. " +
                                "Не теряйте уверенности в успехе, как бы ни складывались обстоятельства. Сегодня многое будет зависеть только от вас. " +
                                "Лучше не торопиться с покупками и сделками. Там, где дело касается денег, вам может быть сложно правильно оценить ситуацию." +
                                " Тут полезным будет опыт людей, которым вы давно доверяете.", "Относитесь серьезно к любой работе, за которую беретесь, " +
                                "иначе вы можете допустить досадные ошибки или упустить что-то важное. Не стоит рассчитывать на легкие успехи, " +
                                "особенно если вы занимаетесь делами не в одиночку, а вместе с кем-то. Придется потратить некоторое время на то," +
                                " чтобы договориться о совместных действиях. Справиться со сложными задачами удастся быстрее, если вы подойдете к ним творчески." +
                                " У вас появятся отличные идеи, которые вряд ли могли бы кому-то еще прийти в голову. Окружающим они очень понравятся.", "Настройтесь на позитивный лад: " +
                                "сегодня это важно для успеха в делах. В первой половине дня стоит сосредоточиться на самых серьезных задачах." +
                                " С их решением вы справитесь гораздо быстрее, чем ожидали, особенно если будете действовать самостоятельно," +
                                " ни от кого не ожидая одобрения или поддержки. Во второй половине дня эмоциональный фон станет более благоприятным, " +
                                "вам будет проще ладить с окружающими, удастся со многими найти общий язык.", "В начале дня может быть нелегко сохранять самообладание." +
                                " Вы будете особенно впечатлительными, станете принимать близко к сердцу то, на что в другое время просто не обратили бы внимания. " +
                                "Старайтесь не переживать из-за мелких неприятностей. Ситуация вскоре изменится к лучшему. Во второй половине дня важно будет обратить внимание на то, " +
                                "как складываются отношения с окружающими. Если вы поведете себя правильно, то сможете восстановить старые связи, " +
                                "помириться с теми, с кем были в ссоре. ", "Трудно будет настроиться на деловой лад. Наверняка захочется отвлечься от забот," +
                                " приятно провести время, заняться чем-то интересным. Но появятся задачи, требующие немедленного решения, " +
                                "так что сосредоточиться все же придется. Можно обратиться за поддержкой к давним знакомым. Они охотно придут вам на выручку. " +
                                "Будет приятно повидаться со старыми друзьями, провести время с близкими людьми. Не исключено, что они порадуют вас " +
                                "хорошими новостями или приятными сюрпризами. Вечер сложится особенно хорошо для влюбленных", "Избегайте споров в начале дня. " +
                                "Это время едва ли подойдет для обсуждения важных вопросов, особенно тех, из-за которых и раньше было немало разногласий. " +
                                "Стараясь доказать свою правоту, вы можете невольно задеть кого-то из собеседников, надолго испортить отношения. " +
                                "Стоит сосредоточиться на уже знакомых делах. С ними вы быстро справитесь, результатов добьетесь отличных. Вторая половина дня – время, " +
                                "когда многим будет полезно побыть наедине с собой. Представители знака смогут разобраться в своих чувствах, обретут уверенность и спокойствие," +
                                " которых в последнее время не хватало.", "Отличный день для новых начинаний. Им будет сопутствовать удача, " +
                                "вы быстро добьетесь первых успехов. Вам охотно помогут давние знакомые, люди, которым вы когда-то оказали важные услуги." +
                                " Легко будет даваться учеба. Вы быстро запомните все, что нужно, узнаете много полезного. День подойдет для деловых переговоров, " +
                                "встреч с людьми, с которыми вы хотели сотрудничать. Несложно будет произвести хорошее впечатление: на ваши лучшие качества " +
                                "все сразу обратят внимание. Хорошо сложатся и рабочие поездки.Вы не только добьетесь в них отличных результатов, " +
                                "но и прекрасно проведете время.", "Прислушайтесь к словам тех, кто совсем на вас не похож. " +
                                "Именно от таких людей вы сегодня узнаете нечто важное. Они же могут помочь справиться с важным делом или достичь к цели," +
                                " к которой вы давно стремились. День подойдет для того, чтобы проявить инициативу в работе. " +
                                "Выбирайте самые сложные задачи: вы отлично встретитесь с ними, и все увидят, на что вы способны. " +
                                "Вероятны денежные поступления, в том числе из неожиданных источников. Вторая половина дня подходит для покупок и сделок; " +
                                "они будут выгодными.", "Сосредоточьтесь на решении рабочих задач. Вы справитесь с ними хорошо и заметно упрочите свои " +
                                "профессиональные позиции, а вскоре сможете получить те предложения, о которых давно мечтали. Самых деятельных представителей " +
                                "знака вскоре ждет стремительный карьерный рост, но лишь в том случае, если сегодня они не станут тратить время напрасно." +
                                "Сохранять душевное равновесие сегодня будет легко не всем. Поскольку день будет насыщенным," +
                                " вы можете беспокоиться о том, успеете ли сделать то, что запланировали, не подведут ли вас помощники. " +
                                "Настройтесь на оптимистический лад: сегодня звезды будут на вашей стороне, и многое получится хорошо.", "Начало дня едва ли обойдется без волнений, " +
                                "но серьезных проблем в это время не возникнет. Не тревожьтесь, если что-то пойдет не так: " +
                                "ситуацию вскоре удастся взять под контроль, если вы сохраните самообладание. Середина дня будет особенно благоприятной для работы." +
                                " Вы решите сложные задачи, справитесь с тем, что не получилось у других. Наладятся отношения с руководством и коллегами. " +
                                "Вторая половина дня многих порадует приятными встречами. Не исключены и знакомства с необычными, ни на кого не похожими людьми. " +
                                "Вероятно начало дружеских или романтических отношений.", "Старайтесь реалистично смотреть на вещи и не спешить с решениями. " +
                                "Сегодня вам очень пригодится умение объективно оценивать ситуацию, внимательно наблюдать за происходящим вокруг и делать выводы " +
                                "из увиденного. Вы вовремя заметите чужие ошибки, и это позволит вам избежать собственных промахов. " +
                                "Вторая половина дня – время, когда любые ваши слова будут очень важными для окружающих. " +
                                "Будьте особенно деликатны с теми, кто вам дорог. Лучше воздержаться от критических замечаний и двусмысленных шуток." +
                                " Не отказывайте в поддержке близким, если она потребуется. Все, что вы сделаете для других, вам тоже пойдет на пользу.",
                                "Какими бы сложными ни были задачи, которые принесет этот день, старайтесь решать их самостоятельно. Во-первых, это едва ли получится лучше у кого-то другого," +
                                " во-вторых, вы со всем справитесь гораздо быстрее, если не станете тратить время на обсуждения и споры о том, кто и что должен делать." +
                                "День отлично подойдет для общения в неформальной обстановке. Хотите повидаться со старыми друзьями или провести время с любимым человеком? Ни в чем себе не отказывайте. " +
                                "Звезды обещают, что вы получите массу позитивных эмоций.", "Начало дня будет благоприятным для общения. Это время хорошо подойдет для обсуждения планов, " +
                                "разговоров о будущем. Неожиданно вас поддержат люди, прежде сомневавшиеся в правильности ваших идей. Не исключены интересные предложения, " +
                                "касающиеся работы, долгосрочного сотрудничества. Позже наступит довольно беспокойное время: нужно будет заниматься несколькими делами сразу," +
                                " исправлять чужие ошибки. Вы со всем справитесь, хоть это и будет нелегко. На вечер лучше не планировать ничего особенно утомительного, отдохните.",
                                "Начинайте день с решения самых сложных проблем. Вам не потребуется много времени, чтобы справиться с задачами, прежде многих поставившими в тупик. " +
                                "Правда, проверенные методы едва ли окажутся эффективными, так что будьте готовы придумать что-то новое. Ваши необычные идеи привлекут всеобщее внимание." +
                                " Люди, которые прежде сомневались в ваших талантах, поймут, как сильно ошибались. Свободное время стоит посвятить активному отдыху:" +
                                " благодаря ему вы почувствуете себя бодрее и энергичнее. Хорошо сложатся поездки, особенно если вы отправитесь в дорогу вместе с кем - то из близких.",
                                "Не стесняйтесь привлекать к себе внимание и проявлять лидерские качества. Сегодня многие обратят внимание именно на ваши сильные стороны, заметят таланты," +
                                " о которых прежде на догадывались. Захотят подружиться те, кто прежде держался холодно и неохотно шел на контакт, а на смену неприязни может прийти симпатия или романтический интерес." +
                                "День хорошо подходит для учебы, исследовательской работы, любых занятий, связанных со сбором и анализом информации." +
                                " Несколько сложнее будет обстоять дело там, где нужны фантазия и творческий подход. Но тут вам наверняка помогут друзья и хорошие знакомые.",
                                "Подходящий день для важных разговоров. Для них найдется масса интересных и серьезных тем. Не спешите браться за дела," +
                                " если пока не знаете точно, как добиться в них успеха. Подождите, соберите побольше информации, посоветуйтесь с теми, кому доверяете. " +
                                "Все это позволит избежать многих неприятных моментов. Эмоциональный фон, напряженный в первой половине дня, с каждым часом будет становиться все более гармоничным. " +
                                "Вечер – благоприятное время для общения с близкими. Достичь взаимопонимания будет нетрудно.","Придется потрудиться, чтобы добиться успеха в делах. " +
                                "Сложно будет собраться с мыслями, настроиться на серьезный лад. Очень силен будет соблазн просто отложить все на потом. " +
                                "Не поддавайтесь ему! Как раз сейчас стоит действовать решительно, ведь есть шанс добиться большого успеха. Вероятны досадные финансовые потери, неожиданные расходы. " +
                                "Особенно переживать из-за них не стоит, ведь вскоре у вас появится возможность пополнить свой бюджет. Обсуждение любых вопросов, " +
                                "связанных с деньгами и имуществом, лучше отложить до вечера.", "Поторопитесь: чем раньше вы возьметесь за дела, тем больше успеете. " +
                                "Не исключено, что придется решать чужие проблемы, но это пойдет на пользу: опыт, который вы получите, вскоре обязательно пригодится. " +
                                "Вероятны удачные покупки и сделки. Во всем, что касается денег, можно полагаться на интуицию, она не подведет." +
                                "Вероятны необычные знакомства, встречи с людьми, которые помогут вам по-новому взглянуть на привычные вещи. " +
                                "Будет возможность пообщаться с людьми, о которых вы прежде слышали много хорошего. " +
                                "Вы легко подружитесь с теми, кто вам понравится.","В начале дня трудно будет избежать суеты и неразберихи," +
                                " сосредоточиться на каком-то одном деле. Это беспокойное, но плодотворное время: вы сделаете много полезного не только для себя, " +
                                "но и для других. Вероятны хорошие новости, касающиеся работы, неожиданные предложения, обещающие скорую прибыль. " +
                                "Во второй половине дня нужно будет сосредоточиться на семейных делах, кому-то из близких потребуются ваши помощь и поддержка. " +
                                "Стоит спокойно обсудить важные для всех вопросы. Скорее всего, решение найдется.","Отличный день для того, чтобы заключать сделки," +
                                " договариваться о сотрудничестве, начинать новые бизнес-проекты. Вы почувствуете, что звезды на вашей стороне, и не захотите тратить время напрасно. " +
                                "Удастся быстро достичь первых успехов, на пути не возникнет преград, которые вы не смогли бы преодолеть. " +
                                "Старайтесь больше рассчитывать на свои силы, чем на чью-то помощь или удачное стечение обстоятельств. " +
                                "Ваша независимость многим понравится. Найдутся желающие познакомиться с вами поближе, возможно начало дружеских или романтических отношений.",
                                "Делитесь идеями, обсуждайте планы, рассказывайте о том, что вам по-настоящему интересно. Именно так вы сегодня сможете найти друзей и союзников," +
                                " познакомиться с теми, кто вскоре поможет вам достичь каких-то важных целей. Не исключены деловые предложения, обещающие скорый рост доходов." +
                                " Тут стоит смотреть на вещи реалистично и прислушиваться только к тем, чей опыт заслуживает доверия. " +
                                "День будет благоприятным для общения с коллегами и руководством. Помните: любые рабочие вопросы можно обсуждать в неформальной обстановке," +
                                " так будет гораздо эффективнее и проще.", "Не горячитесь. Сегодня особенно важно сохранять самообладание и не поддаваться на провокации." +
                                " День откроет много новых возможностей, но для того, чтобы ими воспользоваться, потребуются самообладание и хладнокровие." +
                                " Стоит проявить разборчивость в деловых контактах, не делитесь своими секретами со всеми подряд. " +
                                "В работе смогут добиться заметных успехов те, кто полагаются на надежных союзников, не пытаются со всем справиться самостоятельно." +
                                " Можно заниматься оформлением документов: тут сложностей не возникнет.", "Смело беритесь за решение сложных задач. " +
                                "День обещает большие победы тем, кто не отступает перед трудностями, старается преодолеть все преграды, возникающие на пути. " +
                                "Полезно будет проявить инициативу в деловой сфере. На ваши идеи обратят внимание люди, от которых многое зависит." +
                                " Благодаря их поддержке вы быстро добьетесь успеха. Не всегда будет просто ладить с близкими. Возможны моменты недопонимания, " +
                                "порой будут вспоминаться какие-то старые обиды. Но вы найдете подход к каждому, постараетесь сгладить острые углы, вовремя разрядите обстановку.",
                                "Будьте готовы заниматься несколькими делами сразу. Это окажется не так уж сложно: вы быстро поймете, что требует немедленного внимания, " +
                                "а что может подождать, не станете тратить слишком много времени на пустяки. К тому же интуиция подскажет, как быстрее достичь цели," +
                                " так что не забудьте к ней прислушаться. Ладить с окружающими вам сегодня будет особенно легко. Вы быстро найдете общий язык с новыми знакомыми," +
                                " а с близкими людьми обсудите массу вопросов, избежав при этом разногласий и споров. " +
                                "Вечер – отличное время для того, чтобы строить планы вместе с любимым человеком.", "Сосредоточьтесь на работе: сегодня у вас будет шанс решить сложные задачи, " +
                                "укрепить свои профессиональные позиции. Если вы поделитесь с кем-то своими идеями, они наверняка получат поддержку. " +
                                "Может начаться долгое и плодотворное сотрудничество. Некоторые представители знака подружатся с теми, с кем прежде работали. " +
                                "Сегодня вы получите много интересной информации из нескольких источников. Помните: ее нужно проверять." +
                                "К сожалению, не все сейчас говорят вам правду.Кто - то делает это специально, а кто-то и сам заблуждается.",
                                "Смело говорите то, что думаете. Именно это поможет найти новых помощников и союзников, подружиться с людьми, " +
                                "которые давно вам симпатичны. Те, кто не разделяют вашу точку зрения, просто предпочтут держаться подальше, не станут мешать вам достичь цели." +
                                "День обещает интересные предложения, которые сейчас заняты поиском работы или хотели бы увеличить свои доходы. " +
                                "Легких денег звезды не обещают, но и сверхъестественных усилий от вас не потребуется. Наверняка пригодятся знания и опыт, полученные раньше.",
                                "Не пытайтесь в одиночку справиться со всеми делами, которые появятся сегодня, лучше подумайте о том, кто мог бы вам помочь." +
                                " Рядом наверняка найдутся люди, с которыми вы легко договоритесь о совместных действиях. Не исключено, что принять участие в реализации " +
                                "ваших планов захотят какие-то очень известные и влиятельные особы. Вероятны удачные совпадения и хорошие новости. " +
                                "Помните: действовать сегодня нужно быстро, по возможности не тратя слишком много времени на размышления." +
                                " Точные и своевременные подсказки интуиции в этом помогут.", "Сегодня многие будут обращаться к вам за поддержкой и советом. " +
                                "Вы не утратите самообладания, даже если абсолютно все будет идти не по плану, не поддадитесь на провокации, в любой сложной " +
                                "ситуации примете верное решение. Будет шанс завершить сложное дело, которому вы отдали немало сил. " +
                                "Не исключено, что в этом помогут люди, прежде не раз поддерживавшие ваши необычные идеи. " +
                                "Общие заботы очень сблизят, вы подружитесь с теми, с кем прежде поддерживали только рабочие отношения. " +
                                "Вечер подойдет для романтического свидания.", "Не торопитесь. Первая половина дня едва ли подойдет для серьезных дел: " +
                                "сосредоточиться будет трудно, вы можете допустить досадные ошибки. Однако влияние позитивных тенденций будет быстро усиливаться." +
                                " К тому же вы наверняка встретите людей, к которым можно обратиться за помощью. Благодаря их поддержке решатся вопросы, " +
                                "прежде ставившие вас в тупик. Чем ближе вечер, тем больше у вас будет появляться хороших идей." +
                                " Будут и возможности для их осуществления. Тут важно не растеряться, вовремя сделать первый шаг. На ваши успехи обратят внимание" +
                                " те, кому вы давно хотели понравиться.","Старайтесь вести себя максимально дружелюбно: сегодня это очень поможет в работе. " +
                                "Многие вопросы делового характера полезно будет обсудить в неофициальной обстановке, опустив личные формальности. " +
                                "Благодаря умению быстро находить подход к очень разным людям вы преодолеете бюрократические преграды, сможете избежать " +
                                "многих неприятных моментов. День хорошо подойдет для небольших покупок. Деньги вы станете тратить только на полезные " +
                                "вещи и быстро выберете то, что порадует и вас, и ваших близких.", "Не нужно торопиться. Вы добьетесь успеха, " +
                                "если будете действовать последовательно, избегать лишней суеты. Решайте самостоятельно, на чем вы сосредоточитесь сейчас, " +
                                "а что отложите на потом. Советы знакомых едва ли будут полезными, а вот сбить вас с толку, к сожалению, могут. " +
                                "Ладить с окружающими может быть сложнее, чем обычно. Порой будет казаться, что они специально испытывают ваше терпение," +
                                " стараются вывести из равновесия. Но если вы сохраните доброжелательность и чувство юмора, острых моментов и конфликтов " +
                                "удастся избежать.", "Действуйте быстро. Это особенно важно в первой половине дня: если не тратить время на пустяки, можно успеть очень многое. " +
                                "Вам будут помогать очень разные люди, даже те, от кого вы не ожидали ничего подобного. " +
                                "Не упустите возможность подружиться с теми, кто давно вам симпатичен. Вторая половина дня пройдет несколько спокойнее, " +
                                "но и она будет по-своему хороша. Вероятны успехи там, где требуются фантазия и творческий подход. Некоторые найдут" +
                                " неожиданное применение своим талантам и приятно удивят всех.", "Сегодня будет особенно важно не поддаваться на провокации и сохранять" +
                                " доброжелательный и оптимистичный настрой, как бы ни складывались обстоятельства. Скорее всего, вам придется иметь дело с людьми, " +
                                "к которым непросто найти подход. Едва ли кто-то другой смог бы справиться с этим лучше.Возможны небольшие разногласия на работе и дома," +
                                " но вы быстро поймете, как сгладить острые углы. Будет возможность порадовать близких. Не забудьте поделиться с ними хорошими новостями. " +
                                "Не исключено, что появится повод для домашнего праздника, и он удастся на славу.", "Отличный день для делового общения." +
                                " Хорошо пройдут встречи с потенциальными партнерами и работодателями, переговоры завершатся именно так, как вы хотели." +
                                " Удачно решатся и финансовые вопросы. Некоторые представители знака смогут добиться заметного роста доходов." +
                                "Легко будет даваться учеба. Вы быстро запомните все, что нужно, разберетесь в том, что прежде казалось сложным. " +
                                "С вами охотно поделятся своим опытом и давние, и новые знакомые. Хорошо сложатся поездки – и запланированные, " +
                                "и те, решение о которых было принято в последнюю минуту.", "Потребуется немало терпения, чтобы сохранить хорошие отношения с коллегами." +
                                " На работе могут чаще обычного возникать разногласия, и причиной их может быть простое недопонимание. " +
                                "Поэтому будьте готовы снова и снова объяснять простые вещи, отвечать на одни и те же вопросы. Люди, которых вы сегодня поддержите, " +
                                "вскоре окажут вам важные услуги. Общение с близкими, напротив, будет радовать. " +
                                "Могут появиться какие-то общие планы, их осуществлением вы вместе займетесь в ближайшее время." +
                                " Вечер подойдет для романтического свидания.","Начинайте день с самых важных дел. В первой его половине звезды будут к вам особенно благосклонны, " +
                                "и вы отлично справитесь даже с тем, что в другое время далось бы трудно. Помогут новые знакомые. " +
                                "Благодаря их знаниям и опыту вы сможете избежать серьезных проблем, досадных недоразумений. " +
                                "Отношения, которые начинаются как деловые, примут дружеский характер, если вы проявите инициативу." +
                                "Возможны денежные поступления, в том числе из неожиданных источников. Не исключены и подарки. Некоторые представители знака" +
                                " получат именно то, о чем давно мечтали." };
            
            this.label3.MaximumSize = new Size(600, 300);
            Random rnd = new Random();
            int index = rnd.Next(0, horo.Length);

            string x = horo[index];
            return x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("dd.MM.yyyy");


            int a = dateTimePicker1.Value.Day;
            int b = dateTimePicker1.Value.Month;
            
            if ((a >= 21) && (b == 03) || (a <= 20) && (b == 04))
            {
                comboBox1.SelectedIndex = 0;
            }
            else if ((a >= 21) && (b == 04) || (a <= 21) && (b == 05))
            {
                comboBox1.SelectedIndex = 1;
            }
            else if ((a >= 22) && (b == 05) || (a <= 21) && (b == 06))
            {
                comboBox1.SelectedIndex = 2;
            }
            else if ((a >= 22) && (b == 06) || (a <= 22) && (b == 07))
            {
                comboBox1.SelectedIndex = 3;
            }
            else if ((a >= 23) && (b == 07) || (a <= 21) && (b == 08))
            {
                comboBox1.SelectedIndex = 4;
            }
            else if ((a >= 22) && (b == 08) || (a <= 23) && (b == 09))
            {
                comboBox1.SelectedIndex = 5;
            }
            else if ((a >= 24) && (b == 09) || (a <= 23) && (b == 10))
            {
                comboBox1.SelectedIndex = 6;
            }
            else if ((a >= 24) && (b == 10) || (a <= 22) && (b == 11))
            {
                comboBox1.SelectedIndex = 7;
            }
            else if ((a >= 23) && (b == 11) || (a <= 22) && (b == 12))
            {
                comboBox1.SelectedIndex = 8;
            }
            else if ((a >= 23) && (b == 12) || (a <= 20) && (b == 01))
            {
                comboBox1.SelectedIndex = 9;
            }
            else if ((a >= 21) && (b == 01) || (a <= 19) && (b == 02))
            {
                comboBox1.SelectedIndex = 10;
            }
            else if ((a >= 20) && (b == 02) || (a <= 20) && (b == 03))
            {
                comboBox1.SelectedIndex = 11;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        label3.Text = CreateHoro();
                        pictureBox1.Visible = true;

                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Goroskop\IMG\овен.jpg");
                        break;
                    }
                case 1:
                    {
                        label3.Text = CreateHoro();
                        pictureBox1.Visible = true;
                                               
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Goroskop\IMG\телец.jpg");
                        break;
                    }
                case 2:
                    {
                        label3.Text = CreateHoro();
                        pictureBox1.Visible = true;

                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Goroskop\IMG\близнецы.jpg");
                        break;

                    }
                case 3:
                    {
                        label3.Text = CreateHoro();
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Goroskop\IMG\рак.jpg");
                        break;
                    }
                case 4:
                    {
                        label3.Text = CreateHoro();
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Goroskop\IMG\лев.jpg");
                        break;
                    }
                case 5:
                    {
                        label3.Text = CreateHoro();
                        pictureBox1.Visible = true;

                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Goroskop\IMG\дева.jpg");
                        break;
                    }
                case 6:
                    {
                        label3.Text = CreateHoro();
                        pictureBox1.Visible = true;

                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Goroskop\IMG\весы.jpg");
                        break;
                    }
                case 7:
                    {
                        label3.Text = CreateHoro();
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Goroskop\IMG\скорпион.jpg");
                        break;
                    }
                case 8:
                    {
                        label3.Text = CreateHoro();
                        pictureBox1.Visible = true;

                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Goroskop\IMG\стрелец.jpg");
                        break;
                    }
                case 9:
                    {
                        label3.Text = CreateHoro();
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Goroskop\IMG\козерог.jpg");
                        break;
                    }
                case 10:
                    {
                        label3.Text = CreateHoro();
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Goroskop\IMG\водолей.jpg");
                        break;
                    }
                case 11:
                    {
                        label3.Text = CreateHoro();
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Goroskop\IMG\рыбы.jpeg");
                        break;
                    }
            }
        }
    }
}