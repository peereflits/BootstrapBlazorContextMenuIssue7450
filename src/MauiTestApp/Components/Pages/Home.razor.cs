using BootstrapBlazor.Components;

namespace MauiTestApp.Components.Pages;

public partial class Home
{
    private readonly TextData[] data = BuildData();

#if DEBUG
    private string Configuration => "Debug mode";
#else
    private string Configuration => "Release mode";
#endif

    private async Task OnAddBookmarkAsync(ContextMenuItem item, object value)
    {
        if (value is TextData)
        {
            // Add bookmark logic here
            await Task.Delay(TimeSpan.FromMilliseconds(200));
        }
    }

    private static TextData[] BuildData()
    {
        return
        [ new TextData
          { Id  = "U0_0_1"
          , Key = "0:0.1"
          , Content1 = "IN THE MINDS of the mortals of Urantia—that being the name of your world—there exists great confusion respecting the meaning of such terms as God, divinity, and deity. Human beings are still more confused and uncertain about the relationships of the divine personalities designated by these numerous appellations. Because of this conceptual poverty associated with so much ideational confusion, I have been directed to formulate this introductory statement in explanation of the meanings which should be attached to certain word symbols as they may be hereinafter used in those papers which the Orvonton corps of truth revealers have been authorized to translate into the English language of Urantia."
          , Content2 = "玉苒厦(Urantia)是你们所在这个世界的名字，在该界凡人们的心智中，有关像神、神明和神灵这类术语，在意义上存在着极大的混淆。而人类对于这些纷繁名称所指涉的神格们之间的关系，则更是迷惑不解而又无所适从。鉴于这种伴随着如此多观念上的混淆而来的概念上的贫乏，我受命撰写这篇引言性的综述，来阐明在这批文献中以后将会用到的某些术语的含义。奥温顿(Orvonton)的真理启示者团队，经授权将这些文献以玉苒厦世界的英语来转述。"
          }
        , new TextData
          { Id  = "U0_0_2"
          , Key = "0:0.2"
          , Content1 = "It is exceedingly difficult to present enlarged concepts and advanced truth, in our endeavor to expand cosmic consciousness and enhance spiritual perception, when we are restricted to the use of a circumscribed language of the realm. But our mandate admonishes us to make every effort to convey our meanings by using the word symbols of the English tongue. We have been instructed to introduce new terms only when the concept to be portrayed finds no terminology in English which can be employed to convey such a new concept partially or even with more or less distortion of meaning."
          , Content2 = "在我们力图扩展人们的宇宙意识、提高人们的灵性感知的努力中，由于受制于只能使用这个世界中的一种既定语言，这使得我们在介绍扩展的概念和先进的真理时，遭遇到极大的困难。但是，我们的授权者告诫我们尽力使用英语中的字符来表达我们的意思。我们被晓喻，只有当被描述的概念在英语里找不到相关术语时才引入新的词汇，这样的新词汇被应用来部分地表达这个新概念，甚或是伴随着或多或少的意义上的扭曲。"
          }
        , new TextData
          { Id  = "U0_0_3"
          , Key = "0:0.3"
          , Content1 = "In the hope of facilitating comprehension and of preventing confusion on the part of every mortal who may peruse these papers, we deem it wise to present in this initial statement an outline of the meanings to be attached to numerous English words which are to be employed in designation of Deity and certain associated concepts of the things, meanings, and values of universal reality."
          , Content2 = "为了让研读这批文献的每一个凡人易于理解和避免混淆，我们认为在这篇开宗明义的序文中，宜对附属于众多英语词汇的含义，作一概括说明。这些英语词汇将被用来指涉神灵，以及宇宙实相中与神灵相关的事物、意义和价值所包含的特定概念。"
          }
        , new TextData
          { Id       = "U0_0_4"
          , Key      = "0:0.4"
          , CssClass = "ubts"
          , Content1 = "But in order to formulate this Foreword of definitions and limitations of terminology, it is necessary to anticipate the usage of these terms in the subsequent presentations. This Foreword is not, therefore, a finished statement within itself; it is only a definitive guide designed to assist those who shall read the accompanying papers dealing with Deity and the universe of universes which have been formulated by an Orvonton commission sent to Urantia for this purpose."
          , Content2 = "然而，为了撰写这篇关于术语之众多定义与局限的前言，又必然提前用到这些在之后的文献中才会出现的术语。所以，这篇前言本身并非是充分完备的阐释，它只是向那些要阅读这批文献的人提供一个确切的导引。这些文献将讨论神灵和由众多宇宙组成的宇宙，是由专为此目的派往玉苒厦(Urantia)世界的奥温顿(Orvonton)使团撰写的。"
          }
        , new TextData
          { Id  = "U0_0_5"
          , Key = "0:0.5"
          , Content1 = "Your world, Urantia, is one of many similar inhabited planets which comprise the local universe of <em>Nebadon.</em> This universe, together with similar creations, makes up the superuniverse of <em>Orvonton,</em> from whose capital, Uversa, our commission hails. Orvonton is one of the seven evolutionary superuniverses of time and space which circle the never-beginning, never-ending creation of divine perfection—the central universe of <em>Havona.</em> At the heart of this eternal and central universe is the stationary Isle of Paradise, the geographic center of infinity and the dwelling place of the eternal God."
          , Content2 = "你们的世界，玉苒厦(Urantia)，是构成<em>内巴顿(Nebadon)</em>地方宇宙的众多类似的、有居民行星之中的一个。这个宇宙与那些相类似的宇宙一起，构成<em>奥温顿(Orvonton)</em>超级宇宙，我们使团便是来自于该超级宇宙的首府尤沃萨(Uversa)。奥温顿(Orvonton)超级宇宙是七个进化的时空超级宇宙之一，这七个超级宇宙环绕着那无始无终的、神圣完美的造物——<em>哈沃纳(Havona)</em>中央宇宙。在这个永恒的中央宇宙的核心，是恒定的天堂岛。天堂岛是无穷宇宙之地理中心，也是永恒之神的驻居之所。"
          }
        , new TextData
          { Id  = "U0_0_6"
          , Key = "0:0.6"
          , Content1 = "The seven evolving superuniverses in association with the central and divine universe, we commonly refer to as the <em>grand universe;</em> these are the now organized and inhabited creations. They are all a part of the <em>master universe,</em> which also embraces the uninhabited but mobilizing universes of outer space."
          , Content2 = "我们通常将七个进化中的超级宇宙与中央神圣宇宙合称为<em>大宇宙</em>；它们都是现在已经富有条理并有居民居住的世界。它们都是<em>主宇宙</em>的一部分。主宇宙中还包括那些尚未有居民居住，但是正在运转的外部空间宇宙。"
          }
        ];
    }
}

internal sealed record TextData
{
    public required string Id { get; init; }
    public required string Key { get; init; }
    public string CssClass { get; init; } = "ubtn";
    public string LangCode1 { get; init; } = "en";
    public required string Content1 { get; init; }
    public string LangCode2 { get; init; } = "zh";
    public required string Content2 { get; init; }
}
