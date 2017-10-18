using System;
#region 範例參考位置
//參考位置
//https://docs.microsoft.com/zh-tw/dotnet/core/tutorials/library-with-visual-studio
#endregion

#region 依照範例先註解掉
//namespace StringLibrary_for_Core2._0
//{
//      public class Class1
//    {
//    }
//}
#endregion

namespace UtilityLibraries
{
    public static class StringLibrary
    {
        /// <summary>
        /// 類別庫 UtilityLibraries.StringLibrary 
        /// 包含一個名為 StartsWithUpper 的方法，
        /// 它會傳回 Boolean 值，
        /// 指出目前的字串執行個體是否以大寫字元開頭。
        /// Unicode 標準會區別大寫和小寫字元。 
        /// 如果是大寫字元，Char.IsUpper(Char) 方法會傳回 true。
        /// 
        /// 後續步驟
        ///  因為您尚未呼叫它的任何方法，所以它能否正常運作還不得而知。 
        ///  開發程式庫的下一個步驟是使用單元測試專案來測試它。
        ///  單元測試專案 參考位置
        ///  https://docs.microsoft.com/zh-tw/dotnet/core/tutorials/testing-library-with-visual-studio
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool StartsWithUpper(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;

            Char ch = str[0];
            return Char.IsUpper(ch);
        }
    }
}
