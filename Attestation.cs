//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attestation
    {
        public int Id { get; set; }
        public int CountOfPoints { get; set; }
        public string Comment { get; set; }
        public int NumberOfAttestation { get; set; }
        public int IdTeacher { get; set; }
        public int IdAttestationStudent { get; set; }
    
        public virtual AttestationStudent AttestationStudent { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
