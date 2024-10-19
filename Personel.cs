public class Personel{

    private string Ad;

    public string Get_Ad(){
        return this.Ad;
    }
    public void Set_Ad(string ad){
        this.Ad = ad;
    }

    private int Maas;
    public int Get_Maas(){
        return this.Maas;
    }
    public void Set_Maas(int maas){
        this.Maas = maas;
    }

    public Personel(string ad,int maas)
    {

        // kapsülleme yaptığınızda, kesinlikle ctor içerisinden gelen parametreleri direk değişkenlere atamayınız
        // burada da yine kapsüllemeye değeri gönderiniz

        // yanlış kullanım
        //this.Ad = ad;
        //this.Maas = maas;

        // doğru kullanım 
        this.Set_Ad(ad);
        this.Set_Maas(maas);
    }
}