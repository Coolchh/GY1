//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movies
    {
        public int MoviesID { get; set; }
        public string MoviesName { get; set; }
        public string Image { get; set; }
        public string Brief { get; set; }
        public string Author { get; set; }
        public int TypeID { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public string Url { get; set; }
    }
}
