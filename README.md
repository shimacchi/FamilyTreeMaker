<body style="padding: 2ex;">
    <h1>家系図作成支援ソフトウェアの簡単な取扱説明</h1>
    <hr />
    <p>
        本文書は極めて簡単なこのソフトウェアの使い方を記載したものです。
        もともと、使用マニュアルなどなくても分かりやすいようなインターフェースであることを心がけましたが、
        あまり目立たない機能も含めて記載しましたので、参考にしてください。
    </p>
    <hr />
    <ol>
        <li><a href="#spec">主要な仕様</a></li>
        <li><a href="#add">人物の追加</a></li>
        <li><a href="#del">人物の削除</a></li>
        <li><a href="#move">人物の移動</a></li>
        <li><a href="#attr">人物の属性</a></li>
        <li><a href="#relation">人物間の関係</a></li>
        <li><a href="#save">家系図の保存</a></li>
        <li><a href="#rest">制限事項</a></li>
    </ol>

  <h2 id="spec">主要な仕様</h2>
    <p>
        現時点で描画する世代は4世代分(固定)、設定可能な列数は最小10列、最大40列までです。
    </p>

  <h2 id="add">人物の追加</h2>
    <p>
        空のセルを選んでマウスの右クリックで現れるメニューから性別を指定して人物を追加できます。
        その他の機能として、ダブルクリックで「男性」の人物を追加することもできます。
        人物の情報として「名前」は内部的には何も使用していません。
        (内部的な区別は背後でつけているIDでしています)そのため、
        「名前」はあくまでも作成側が区別するためのメモ程度の意味です。
    </p>

   <h2 id="del">人物の削除</h2>
    <p>
        既に人物がいるセルを選んでマウスの右クリックで現れるメニューから削除を選べば確認ののち、削除できます。
        なお、関係設定が複雑になるため<b>配偶者関係があったり、親子関係が設定されていると削除できない</b>仕様にあえてしているため
        人物の削除が必要な場合にはそれらの関係性を全て削除してからにしてください。
    </p>

  <h2 id="move">人物の移動</h2>
    <p>
        <b>同じ世代間であれば</b>ドラッグすることで空のセルに既にいる人物の位置を移動させることができます。
    </p>

  <h2 id="move">人物の属性</h2>
    <p>
        作成された人物の属性(性別や罹患者であるとか、死亡しているとか)は、右側のチェックボックスやラジオボックスで変更できます。
        なお、<b>
            罹患者かどうかは「Sキー」、死亡かどうかは「Dキー」で変更でき、
            性別については、「Fキー」で女性に、「Mキー」で男性になります。
        </b>
        これらをショートカットとして設定しています。
        まだ開発中なので、発端者が2人以上いてもエラーにはなりません。
        年齢については「-1」で人物の下に年齢は表示されないようになりますが、0以上の整数値で人物の下に年齢が表示されます。
        死亡の場合には自動的に「d.」がつきます。
    </p>

   <h2 id="relation">人物間の関係</h2>
    <p>
        配偶者関係: 同世代間でしか設定できません。関係元の人物を選び、マウスの右クリックで現れるメニューから「配偶者関係を設定」を選んだあとに
        配偶者関係の対象となる人物をクリックすると、配偶者関係が設定されます。削除は同じように現れるメニューからできます。
        関係設定が複雑になるため、親子関係があると配偶者関係は削除できない仕様にしています。配偶者関係を削除する前に、親子関係をすべて削除してください。
        なお、<b>裏技として同世代間で配偶者関係がなく、性別が異なる場合にはドラッグで配偶者関係が設定できます</b>。
        また、配偶者関係を設定した後に人物の性別は変更でき、女性同士など同性の配偶者関係が維持されますが、
        図表作成の利便性を優先させてたため、そこはあえてチェックしていません。
    </p>

  <p>
        親子関係: 1世代異なる間でしか設定できません。また、親世代に配偶者関係が設定されていないと親子関係も設定できません。
        配偶者関係の設定と同様に、関係元の人物を選んだ後にマウスの右クリックで現れるメニューから「親子関係を設定」を選び、対象の人物を選ぶと親子関係が設定できます。
        親側が先でも、子側が先でも条件を満たしていれば親子関係が設定できます。
        なお、適切な条件の人物間であれば<b>裏技としてドラッグで親子関係が設定できます</b>
    </p>

   <h2 id="save">家系図の保存</h2>
    <p>
        保存のボタンを押すと、ファイル選択ダイアログが出ます。
        ソフトのメイン画面左側の領域に「サイズも含めて」見えているのと同じように画像ファイルになります。
        そのため、画像ファイルの縦横のサイズを変更するにはフォームの大きさを変えれば結構です。
    </p>


  <h2 id="rest">制限事項</h2>
    <p>
        本ソフトウェアは医療者が使用する前提で開発されているものの、極めて限定的な目的に特化したものです。
        すなわち、直感的な操作で、日常診療で使用頻度の高い項目のみ作成可能となっており、家系図作成において国際標準となっているものに完全に準拠しているわけではありません。
        あくまでも医療者個人の情報整理の目的に止めていただきますようお願いいたします。使用者個人のご判断による本ソフトウェアの使用によって発生した損害につきましては、自己責任の範囲としてご理解ください。
    </p>
    <hr />

  <h2 id="pp">プライバシーポリシー</h2>
<p>
Privacy Policy
<ol>
    <li>This application and developer do not collect any personal information or privacy-related information at all.</li>
    <li>This application and developer do not collect any information on keyboard typing by the user.</li>
    <li>This application does not access any files or folders to work except OS automatically does.</li>
    <li>This is a stand-alone application and does not need any Internet access.</li>
</ol>
<ol>
    <li>このアプリケーションはいかなる種類の個人情報も収集しません</li>
    <li>このアプリケーションは動作中のいかなるキーボード操作も記録・収集しません</li>
    <li>このアプリケーションは動作に際して、OSが自動的に行う以外のいかなるファイル/フォルダへのアクセスもありません</li>
    <li>このアプリケーションは単独で動作し、動作に際してインターネット接続は必要ありません</li>
</ol>
</p>

</body>
