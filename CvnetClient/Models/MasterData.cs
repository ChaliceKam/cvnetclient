/* ============================================================================
 * Cvnet8wpfclient.exe : MasterData.cs
 * Created by Sekiya.Sato 2025/05/21
 * 説明: マスターの定義
 * 使用ライブラリ [Library used]:
 *		CommunityToolkit.Mvvm : LICENCE = MIT
 * ============================================================================  */
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvnetClient.Models {
	internal class MasterData {
	}
	public partial class  MasterMeisho : ObservableObject {
		[ObservableProperty]
		long seqNo;
		[ObservableProperty]
		decimal vdateCreate;
		[ObservableProperty]
		decimal vdateUpdate;
		[ObservableProperty]
		string? kubun;
		[ObservableProperty]
		string? meishoCd;
		[ObservableProperty]
		string? meisho;
		[ObservableProperty]
		string? ryakuShou;
		[ObservableProperty]
		string? rank;
		[ObservableProperty]
		string?	renban;
		[ObservableProperty]
		string? kana;
		[ObservableProperty]
		string? posKubun;
		[ObservableProperty]
		string? saishuuShuuseiSha;
	}
	public partial class MasterShohin : ObservableObject
	{
        [ObservableProperty]
        long seqNo;
        [ObservableProperty]
        decimal vdateCreate;
        [ObservableProperty]
        decimal vdateUpdate;
		[ObservableProperty]
		string? productCD; //商品CD
        [ObservableProperty]
		string? productName; //商品名
		[ObservableProperty]
		string? abbreviation; //略称
		[ObservableProperty]
		string? oldCode; //旧コード
		[ObservableProperty]
		string? exhibitCD; // 展示会CD
		[ObservableProperty]
		string? brandCD; //ブランドCD
        [ObservableProperty]
		string? itemCD; //アイテムCD
		[ObservableProperty]
		string? seasonCD; //シーズンCD
		[ObservableProperty]
		string? materialCD;//素材CD
		[ObservableProperty]
		string? designCD; //デザイナーCD
		[ObservableProperty]
		string? manufactCD; //メーカーCD
		[ObservableProperty]
		string? madeInCD; //原産国CD 
    }
}
