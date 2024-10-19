

// Ctor ile encapsulation yan yana geldiği zaman genelde algı ctor'ların, nesnenin üyelerini koruduklarıdır
// ancak, Ctor dediğimiz olay, verileri değişkenlere iletmekten başka bir şey yapmaz

// eğer, bir kapsüllediğimiz değişkenlere ctor ile değer atarsak, kapsüllemenin bir anlamı kalmaz!!!

// ctor'un içerisindeki gönderdiğim değerleri kontrol eden bir kapsülleme olmadığı için, direk değişkenler erişip
// değerlerini değiştirebildim!!!
Personel p = new Personel("harun",2000);