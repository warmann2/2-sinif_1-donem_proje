
    public class Randevular
    {
        
        public int RandevuId { get; set; }
        public DateTime? Gun { get; set; } 
        public DateTime? Saat { get; set; }

        public int HayvanID { get; set; } 
       

        public int VeterinerId { get; set; } //buradaki veterinerId veterinler classından gelmekte foreign key olarak tanımlanmakta
        



    }
