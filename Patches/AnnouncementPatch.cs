using System;
using System.Collections.Generic;
using System.Linq;
using AmongUs.Data;
using AmongUs.Data.Player;
using Assets.InnerNet;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace TownOfHostForE;

public class ModNews
{
    public int Number;
    public int BeforeNumber;
    public string Title;
    public string SubTitle;
    public string ShortTitle;
    public string Text;
    public string Date;

    public Announcement ToAnnouncement()
    {
        var result = new Announcement
        {
            Number = Number,
            Title = Title,
            SubTitle = SubTitle,
            ShortTitle = ShortTitle,
            Text = Text,
            Language = (uint)DataManager.Settings.Language.CurrentLanguage,
            Date = Date,
            Id = "ModNews"
        };

        return result;
    }
}
[HarmonyPatch]
public class ModNewsHistory
{
    public static List<ModNews> AllModNews = new();

    public static void Init()
    {
        {
            var news = new ModNews
            {
                Number = 100002,
                //BeforeNumber = 0,
                Title = "Town Of Host For E  初版リリース！",
                SubTitle = "∠( `•ω•)／TOH4E  待望の初版リリース!ヽ(・ω・′)ゝ",
                ShortTitle = "★TOH4E 初版リリース",
                Text = "TownOfHost For Eをダウンロード頂きありがとうございます！！\n"

                            + "\n Town Of Host For Eはエンジョイ村が大好きな人向けに独自の追加役職を取り入れたMODです。遊んでくれてるってことは多分承知の上だよね？"
                            + "\n "
                            + "\n 初版で実装したイカれた役職は以下の3つだぜ！\n"
                            + "\n 【新役職】爆裂魔・姫・お嬢様\n"

                            + "\n TOH4EはAmongUsでありながら、パーティーゲームのようなゲーム体験を志して今後もアップデートを予定しています！是非楽しみにしてくれると嬉しいな！\n"

                            + "\n【注意】\nプレイする際は必ずTOH4Eであることを明記・通知してください。"
                            + "\nまた、他MODとの共存は出来ません。必ず1つのMODだけを使用するようにしてください。",
                Date = "2023-04-29T00:00:00Z"

            };
            AllModNews.Add(news);
        }
        {
            var news = new ModNews
            {
                Number = 100003,
                //BeforeNumber = 0,
                Title = "Town Of Host For E  412.1.1リリース！",
                SubTitle = "∠( `•ω•)／TOH4Eをアプデしました。!ヽ(・ω・′)ゝ",
                ShortTitle = "★TOH4E 412.1.1★",
                Text = "TownOfHost For Eをダウンロード頂きありがとうございます！！\n"

                    + "\n 【TOHY v412.9役職等の実装】\n"
                    + "\n TOHY v412.9をマージしました。"
                    + "\n そのため、TOHY v412.9の役職、機能が追加されました。"
                    + "\n 詳細はTOHYのGitHubをご確認ください。"
                    + "\n 是非TOH4Eの役職と組み合わせてカオスなアモアスライフを！！\n"
                    + "\n【制限事項】\n"
                    + "TOHY v412.9にて追加されたチャット読み上げ機能を現在利用できないようにしています。ご利用の方はTOHYをご利用くださいませ。恐らく次版では使えるようにします。\n"

                    + "\n 【爆裂魔の調整】\n"
                    + "爆裂後にベントに逃げることが出来るフラグを実装しました。こちらをオフにすることで爆裂魔がベントに逃げることが出来なくなります。お好みで調整してください。\n"

                    + "\n 【不具合のお知らせ】\n"
                    + "現在ホストがお嬢様を引いた場合、発現の語尾が参加者様から正しく見えない不具合が発生しています。いい対処案が思いつき次第対応します。ご不便おかけします。\n"

                    + "\n【注意】\nプレイする際は必ずTOH4Eであることを明記・通知してください。"
                    + "\nまた、他MODとの共存は出来ません。必ず1つのMODだけを使用するようにしてください。",
                Date = "2023-05-09T00:00:00Z"

            };
            AllModNews.Add(news);
        }
        {
            var news = new ModNews
            {
                Number = 100004,
                //BeforeNumber = 0,
                Title = "Town Of Host For E  412.2.0リリース！",
                SubTitle = "∠( `•ω•)／新役職が多数追加されたぞ！!ヽ(・ω・′)ゝ",
                ShortTitle = "★TOH4E 412.2.0★",
                Text = "TownOfHost For Eをダウンロード頂きありがとうございます！！\n"

                    + "\n 【新陣営アニマルズの追加】\n"
                    + "\n 今版にて新陣営のアニマルズが追加されました！"
                    + "\n アニマルズは第3陣営のように個々の勝利条件がありながら、誰か1人でも条件を満たせば全員が勝利する陣営になります。"
                    + "\n 但しアニマルズは同陣営のプレイヤーが誰か分かりません。"
                    + "\n 動物たちの前では全てが些細なことさ！！\n"

                    + "\n 【新役職の追加】\n"
                    + "以下の新役職を実装しました。\n"
                    + "---クルー---\n"
                    + "ネゴシエーター\n"
                    + "\n---インポスター---\n"
                    + "・シンデレラ\n"
                    + "\n---第3陣営---\n"
                    + "・義賊\n"
                    + "\n---アニマルズ---\n"
                    + "・コヨーテ\n"
                    + "・バルチャー\n"
                    + "・アナグマ\n"
                    + "・ブラキディオス\n"

                    + "\n 【新アドオンの追加】\n"
                    + "以下の新アドオンを実装しました。\n"
                    + "・中二病\n"

                    + "\n 【新設定の追加】\n"
                    + "勝利陣営予想投票モードを用意しました。こちらの設定を有効にすることで死亡後に勝利陣営を各々予想して盛り上がってくれると嬉しいなと思ってます。この機能は近日アップデート予定です。\n"

                    + "\n 【不具合のお知らせ】\n"
                    + "v412.1.1に引き続きホストがお嬢様を引いた場合、発現の語尾が参加者様から正しく見えない不具合が発生しています。対処案は見つかっているので次回のアップデートで修正予定です。\n"
                    + "v412.1.1に引き続き棒読みちゃん連携機能に対応しておりません。こちらも後日対応予定です。\n"


                    + "\nその他、役職詳細など詳しいアップデート内容はTOH4EのGitHubを参照ください。。\n"

                    + "\n【注意】\nプレイする際は必ずTOH4Eであることを明記・通知してください。"
                    + "\nまた、他MODとの共存は出来ません。必ず1つのMODだけを使用するようにしてください。",
                Date = "2023-05-20T00:00:00Z"

            };
            AllModNews.Add(news);
        }
        {
            var news = new ModNews
            {
                Number = 100005,
                //BeforeNumber = 0,
                Title = "Town Of Host For E  412.2.2リリース！",
                SubTitle = "∠( `•ω•)／アモアス新バージョンに対応だ！!ヽ(・ω・′)ゝ",
                ShortTitle = "★TOH4E 412.2.2★",
                Text = "TownOfHost For Eをダウンロード頂きありがとうございます！！\n"

                    + "\n 【AmongUs最新版(2023.6.13)対応】\n"
                    + "\n 旧版をご利用いただいていた皆様お待たせしました。"
                    + "\n やっとTOH4Eも最新版で動作するようになりました。"
                    + "\n これからもTOH4Eを楽しんで頂けると幸いです！"

                    + "\n 【新役職の追加】\n"
                    + "以下の新役職を実装しました。\n"
                    + "---クルー---\n"
                    + "ちいかわ\n"
                    + "ナイスゲッサー\n"
                    + "\n---インポスター---\n"
                    + "・イビルゲッサー\n"
                    + "\n---アニマルズ---\n"
                    + "・ヒョウ\n"
                    + "\n ちいかわはターン毎にハチワレ、うさぎに役職が変わる特殊なクルーメイトです！"
                    + "\n それぞれに個性的な能力がありますので是非遊んでみてください！"
                    + "\n 尚ちいかわは普通には選択できません。タイトル画面で指定のコマンドを入力すると出現するという噂が...?\n"
                    + "\n 人気役職ゲッサーを追加しました。ヒョウはアニマルズ陣営のゲッサーになります。ぜひ遊んでみてください。\n"

                    + "\n 【勝利陣営予想投票モードアップデート！】\n"
                    + "恐らく今回のアプデの目玉です！\n"
                    + "死んだ時のみに遊ぶことが出来る勝利陣営予想投票モードが大幅なアップデートを遂げました！\n"
                    + "今まではそのゲーム中のみ有効だったポイントが保管されるようになり、そのポイントを消費して好きな称号を購入可能です！\n"
                    + "称号はMOD導入者以外は試合中のみ有効になります。是非お気に入りの称号を付けて遊んでみてください。称号は外部ファイルで管理しているのでご自由に追加頂いて大丈夫です！\n"

                    + "\n 【不具合のお知らせ】\n"
                    + "ゲーム開始時に参加者がエラーによる切断になった場合、以後の試合にてポイントが割り振られない事象を確認しています。もしそうなってしまった場合は部屋を新しく立て直して頂くと解消されます。\n"

                    + "\nその他、役職詳細など詳しいアップデート内容はTOH4EのGitHubを参照ください。。\n"

                    + "\n【注意】\nプレイする際は必ずTOH4Eであることを明記・通知してください。"
                    + "\nまた、他MODとの共存は出来ません。必ず1つのMODだけを使用するようにしてください。",
                Date = "2023-06-19T00:00:00Z"

            };
            AllModNews.Add(news);
        }
        {
            var news = new ModNews
            {
                Number = 100006,
                //BeforeNumber = 0,
                Title = "Town Of Host ForE  vAMONGUS！",
                SubTitle = "∠( `•ω•)／アモアス新バージョンにやっと正式対応だ！!ヽ(・ω・′)ゝ",
                ShortTitle = "★TOH4E vAMONGUS★",
                Text = "TownOfHost ForEをダウンロード頂きありがとうございます！！\n"

                    + "\n 【注意！！！】今回の更新に辺り、重要なことを記載しておりますので必ず最後までお読みください。 \n"
                    + "\n 【AmongUs最新版(2023.7.12)対応】\n"
                    + "\n 旧版をご利用いただいていた皆様お待たせしました。"
                    + "\n やっとTOH4Eも最新版で動作するようになりました。"
                    + "\n 本当に苦労しました。やっと対応です。\n"

                    + "\n 【公開ルームについて】"
                    + "\n TOH4Eを含め現在のホストMODはAmongUsを開発されているInnersloth様からの指示を受け、野良のユーザー向けの公開ルームが作れない状態です。"
                    + "\n 本版でもその機能は健在であり、部屋作成後に公開ルームにしてもバニラの野良プレイヤーが入ることはありません。"
                    + "\n 但し、同接続方法を取っている他MODの方が入ってくる可能性がある為公開ルームは非推奨です。\n"

                    + "\n 【DB連携について】"
                    + "\n 今版からDBと連携し皆様のゲーム結果などを集計する機能を実装しました。"
                    + "\n この機能は主に皆様とは直接は関係のない機能になりますが、今後の実装方針の参考に役立てようと思っております。"
                    + "\n この機能にご理解頂けない方は本MODを利用できないため、予めご了承ください。"
                    + "\n 本MODの利用をもってこの機能に対し同意を得たものとします。\n"

                    + "\n 【ブラックリスト機能について】"
                    + "\n SuperNewRoles様より提供いただいたブラックリスト機能を実装しております。"
                    + "\n 本機能について詳細を明かすことは出来ませんが、端的に言えばMODの利用に相応しくない人物に利用させないための機能となっております。"
                    + "\n 普段から遊んで頂いている皆様には無縁のお話かとは思いますが、ご理解頂きますようよろしくお願い致します。"
                    + "\n 尚、本機能はTOH4Eのみならず複数MODで有効のため、他MODでBANされた結果4Eが遊べなくなることもありますので合わせてご理解下さい。\n"

                    + "\n 【新機能：BGM機能実装！】"
                    + "\n AmongUsってBGMが鳴らなくて少し味気ないなぁって思ったことはありませんか？"
                    + "\n 今版ではそんな彼方向けにBGM機能を開発しました！"
                    + "\n これを利用すると場面に合わせてその場に合ったBGMを自動で再生してくれます！"
                    + "\n 是非お試しあれ！"
                    + "\n ※詳しい説明はGitHubに記載予定です。\n"

                    + "\n 【新役職の追加】\n"
                    + "以下の新役職を実装しました。\n"
                    + "---クルー---\n"
                    + "・名探偵\n"
                    + "---マッドメイト---\n"
                    + "・マッドトリッカー\n"
                    + "・クモマッドメイト\n"
                    + "\n---インポスター---\n"
                    + "・トークティブ\n"
                    + "・テレポーター\n"
                    + "・人形術師\n"
                    + "\n---第3陣営---\n"
                    + "・ヤンデレ\n"
                    + "\n 各役職の詳細はGitHubをご確認ください！\n"

                    + "\n 【不具合のお知らせ】\n"
                    + "実は以前からホスト以外のMODクライアントがいる場合の動作が安定しておりませんでした。\n"
                    + "こちらについては現在調査中のため次版以降で修正予定です。\n"
                    + "ホスト以外でMODを入れられる場合はご理解の上ご利用ください。発生した不具合は随時報告頂けると今後に繋がります。\n"

                    + "\nその他、役職詳細など詳しいアップデート内容はTOH4EのGitHubを参照ください。。\n"

                    + "\n【注意】\nプレイする際は必ずTOH4Eであることを明記・通知してください。"
                    + "\nまた、他MODとの共存は出来ません。必ず1つのMODだけを使用するようにしてください。",
                Date = "2023-08-12T00:00:00Z"

            };
            AllModNews.Add(news);
        }
        {
            var news = new ModNews
            {
                Number = 100007,
                //BeforeNumber = 0,
                Title = "Town Of Host ForE  vAMONGUS-α！",
                SubTitle = "∠( `•ω•)／TOH4Eを入れてゲームに参加できるようになったよ!ヽ(・ω・′)ゝ",
                ShortTitle = "★TOH4E vAMONGUS-α★",
                Text = "TownOfHost ForEをダウンロード頂きありがとうございます！！\n"

                    + "\n 【主な更新内容！】"
                    + "\n ・Town of Host v5.1.1に対応しました！"
                    + "\n ・TOH4Eをいれた状態でTOH4Eの他のホストのゲームに参加できるようになりました！"
                    + "\n ・少しばかりの新役職とかを追加しました！"
                    + "\n その他諸々バグfix\n"

                    + "\n 【Town of Host 5.1.1対応!！】"
                    + "\n ある日TOH4Eを色々いじっていると突然本家TOHのアップデートが告知されました。"
                    + "\n ワクワクして覗いてみるとそこには沢山の新役職が...!!!"
                    + "\n ということで早速マージし、TOH4Eでもv5.1.1の追加要素が使えるようになりました。"
                    + "\n とても楽しいアプデだったので、是非遊んで貰えると幸いです。"
                    + "\n ※本家TOHのアプデ情報についてはTOHのGitHubをご覧ください。\n"

                    + "\n 【TOH4E参加側でもMODを入れれるようになりました！】"
                    + "\n 今までの4EはホストのみしかModを入れることが出来ず、他が入れると色々問題が起こっておりました...。"
                    + "\n 折角PCから参加するならModを入れて遊びたい!というのが本音。とてもよく分かります...。\n本家TOHは参加側もMod入れれますもんね。\n"
                    + "\n なのでこの度....\n<size=180%>元MODの処理から何から全てを見直して</size>\n遂に参加側もMODを入れて遊べるようになりました!"
                    + "\n 不具合調査から修正まで想定していた以上に時間がかかりましたが、労力に見合うだけの修正を行えたと思います...！"
                    + "\n TOH4EはMod入れれる人なら入れたほうが絶対楽しいので是非入れて参加してみてください！！"
                    + "\n ※TOH4Eの独自要素である称号に関してはまだ参加側に上手く反映できておりません。こちらは次版で対応予定です。\n"

                    + "\n 【新役職の追加】\n"
                    + "以下の新役職を実装しました。\n"
                    + "---クルー---\n"
                    + "・メタトン(隠し役職)\n"
                    + "\n---インポスター---\n"
                    + "・イレイサー\n"
                    + "\n---アニマルズ---\n"
                    + "・レッサーパンダ\n"
                    + "\n---属性---\n"
                    + "・ギャンブラー\n"
                    + "\n 各役職の詳細はGitHubをご確認ください！\n"

                    + "\nその他、役職詳細など詳しいアップデート内容はTOH4EのGitHubを参照ください。。\n"

                    + "\n【注意】\nプレイする際は必ずTOH4Eであることを明記・通知してください。"
                    + "\nまた、他MODとの共存は出来ません。必ず1つのMODだけを使用するようにしてください。",
                Date = "2023-09-24T00:00:00Z"

            };
            AllModNews.Add(news);
        }
        {
            var news = new ModNews
            {
                Number = 100008,
                //BeforeNumber = 0,
                Title = "Town Of Host ForE  vBOMB！",
                SubTitle = "∠( `•ω•)／新ゲームモードが登場！!ヽ(・ω・′)ゝ",
                ShortTitle = "★TOH4E vBOMB★",
                Text = "TownOfHost ForEをダウンロード頂きありがとうございます！！\n"

                    + "\n 【主な更新内容！】"
                    + "\n ・新ゲームモード：大惨事爆裂大戦が実装されました！"
                    + "\n ・新役職が2つ追加されました！可愛がってね！"
                    + "\n ・既存役職に少しばかりの追加設定が入りました！"
                    + "\n ・ラバーズが複数組作成可能に！"
                    + "\n ・言葉制限モードが実装されました！\n"

                    + "\n 【新ゲームモード：大惨事爆裂大戦実装！!！】"
                    + "\n TOH4Eを好んでくれている方ならこのモードの名を既にご存じかもしれません。"
                    + "\n 等々皆様のお部屋で大惨事爆裂大戦が遊べるようになりました！"
                    + "\n ルールは単純！　爆弾を持つな！　生き残れ！　巻き込まれるな！"
                    + "\n これを意識していればきっと勝てます。きっと。"
                    + "\n 是非モードを切り替えて遊んでみてください。"
                    + "\n ※大惨事爆裂大戦ではBGMモードも有効です。しかも前もって設定していなくても再生されるとか...!?\n"

                    + "\n 【新役職が追加されました！】"
                    + "\n 新役職としてドッグシェリフとクサネコが追加されました。"
                    + "\n ドッグシェリフはペット撫ででキルを行うシェリフであり、シェリフと違いタスクを付与できます。"
                    + "\n シェリフもクルーだしタスク与えたいよなぁ、って人にはオススメです。"
                    + "\n クサネコはアニマルズの期待の新星です。"
                    + "\n 何とペットと協力して強力な光弾を射出可能！他のプレイヤーを殲滅しよう！"
                    + "\n クサネコの光弾は目に見えないけど、何となくの位置は他プレイヤーは察知しているのでお気を付けを。\n"

                    + "\n 【既存役職に設定が追加されました！】"
                    + "以下の役職に新規設定を追加しました。\n"
                    + "---クルー---\n"
                    + "・メイヤー：スキップで投票数を保存する\n"
                    + "\n---インポスター---\n"
                    + "・テレポーター：他クルーにゲートの場所を知らせる、ゲートを一方通行にする、ゲート再設置不可\n"
                    + "\n 各役職の詳細はGitHubをご確認ください！\n"

                    + "\n 【ラバーズが複数組作成可能になりました！】"
                    + "\n 今まではラバーズは一組のみでしたが、複数組作成可能になりました。"
                    + "\n これによりアドオンのラバーズや純愛者、姫ちゃんなどを同時に配役することが出来るようになりました。"
                    + "\n ただし、その際少しばかり勝利条件が変わるためご注意ください。"
                    
                    + "\n 【言葉制限モードが実装されました！】"
                    + "\n よく配信などで語尾んぐあすとかそういう企画ありますよね？？"
                    + "\n やってみたいと思いませんか？(みた～い)"
                    + "\n ということで今回実装しました。言葉制限モードです。"
                    + "\n 制限内容として、「平仮名禁止」「カタカナ禁止」「アルファベット禁止」「指定ワード必須」を選べます。(多少語感違うかもしれませんが)"
                    + "\n 指定ワード必須を利用する際は事前に「/swl」コマンドにて、言葉を指定してください"

                    + "\nその他、役職詳細など詳しいアップデート内容はTOH4EのGitHubを参照ください。。\n"

                    + "\n【注意】\nプレイする際は必ずTOH4Eであることを明記・通知してください。"
                    + "\nまた、他MODとの共存は出来ません。必ず1つのMODだけを使用するようにしてください。",
                Date = "2023-12-24T00:00:00Z"

            };
            AllModNews.Add(news);
        }
        {
            var news = new ModNews
            {
                Number = 100009,
                //BeforeNumber = 0,
                Title = "Town Of Host ForE  vBOMB-α！",
                SubTitle = "∠( `•ω•)／不具合修正とかその辺のアプデヽ(・ω・′)ゝ",
                ShortTitle = "★TOH4E vBOMB★",
                Text = "TownOfHost ForEをダウンロード頂きありがとうございます！！\n"

                    + "\n 【主な更新内容！】"
                    + "\n ・新役職：運営者が追加！"
                    + "\n ・レンタルペット機能を実装！"
                    + "\n ・その他不具合修正+TOH5.1.5対応！\n"

                    + "\n 【新役職が追加されました！】"
                    + "\n 新役職として運営者が追加されました！"
                    + "\n 運営者はキルボタンでデスゲームの参加者を選択し、2名選択後に会議中で自投票することでデスゲームを開催することが出来ます！"
                    + "\n デスゲーム中は選択されたプレイヤー2名はペットを撫でることで相手をキルすることが可能になります。他のプレイヤーをキルは出来ません。"
                    + "\n またこのデスゲーム中はタスク、キル、サボタージュを行ったプレイヤーは死亡してしまうのでアサイン時はご注意ください。"
                    + "\n 運営者は指定回数デスゲームを開催した上で、指定人数以下生存中に会議を開催することで勝利判定されます。"
                    + "\n この指定回数は設定で変更可能ですので自由に難易度を調整してください。\n"

                    + "\n 【レンタルペット機能を実装】"
                    + "\n クサネコ、ドッグシェリフ、クモマッド、義賊、アナグマ...etc..."
                    + "\n ペットを使う系の役職が増えてきました。"
                    + "\n それに伴って度々発生したのが「ペットの付け忘れ」による実質役職効果なしのプレイヤー。\n"
                    + "\n これの対策としてレンタルペット機能を付けました。"
                    + "\n 自身で持ち込んだペットが優先されるのでそこはご安心を。"
                    + "\n ※レンタルされるペットはハムのペットになります。その試合中でのみ有効です。"
                    + "\nその他、役職詳細など詳しいアップデート内容はTOH4EのGitHubを参照ください。。\n"

                    + "\n【注意】\nプレイする際は必ずTOH4Eであることを明記・通知してください。"
                    + "\nまた、他MODとの共存は出来ません。必ず1つのMODだけを使用するようにしてください。",
                Date = "2024-03-17T00:00:00Z"

            };
            AllModNews.Add(news);
        }
    }

    [HarmonyPatch(typeof(PlayerAnnouncementData), nameof(PlayerAnnouncementData.SetAnnouncements)), HarmonyPrefix]
    public static bool SetModAnnouncements(PlayerAnnouncementData __instance, [HarmonyArgument(0)] ref Il2CppReferenceArray<Announcement> aRange)
    {
        if (AllModNews.Count < 1)
        {
            Init();
            AllModNews.Sort((a1, a2) => { return DateTime.Compare(DateTime.Parse(a2.Date), DateTime.Parse(a1.Date)); });
        }

        List<Announcement> FinalAllNews = new();
        AllModNews.Do(n => FinalAllNews.Add(n.ToAnnouncement()));
        foreach (var news in aRange)
        {
            if (!AllModNews.Any(x => x.Number == news.Number))
                FinalAllNews.Add(news);
        }
        FinalAllNews.Sort((a1, a2) => { return DateTime.Compare(DateTime.Parse(a2.Date), DateTime.Parse(a1.Date)); });

        aRange = new(FinalAllNews.Count);
        for (int i = 0; i < FinalAllNews.Count; i++)
            aRange[i] = FinalAllNews[i];

        return true;
    }
}
