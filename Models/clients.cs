
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LibraryProject.Models
{

using System;
    using System.Collections.Generic;
    
public partial class clients
{

    public int client_id { get; set; }

    public Nullable<int> id_trading { get; set; }

    public string name { get; set; }

    public string surname { get; set; }

    public string patronymic { get; set; }

    public System.DateTime birthday { get; set; }

    public string address { get; set; }

    public string workplace { get; set; }

    public string studyplace { get; set; }

    public Nullable<int> id_role { get; set; }

    public string phone { get; set; }

    public string login { get; set; }

    public string password { get; set; }



    public virtual roles roles { get; set; }

    public virtual trading trading { get; set; }

}

}
