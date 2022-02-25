using System;
using ProjectRPG.src.Entities;

Form knight = new Knight("Arus", 23, "Kinight", 100, 300);
Form wizzard = new Wizzard("Jannie", 20, "Withe Wizzard", 100, 175);
Form ninja = new Ninja("Tify", 30, "Ninja", 100, 150);
Form fighter = new Fighter("Monkey D.", 50, "Fighter", 100, 250);
Form bossKnight = new Boss("Crash", 200,"Monstro", 1000, 500 );
Form bossWizzard = new Boss("Etherium", 1000,"Orc", 500, 250 );
Form bossNinja = new Boss("Orochimaru", 750,"Serpente", 400, 600 );
Form bossFighter = new Boss("Kaido", 2000,"Demoniaco", 1268, 600 );

Console.WriteLine("Bem-Vindos Caros Jogadores, Esta é o Jogo Defenda a  Guilda GFT!! \r\nÉ muito Simples, escolha um Heroi e Derrote o Boss!! \r\nVamos La! ");

    Console.WriteLine("Digite Seu nome: "); 
    string nameUser = Console.ReadLine();
    
    Console.WriteLine( $" \r\nVamos Começar!! {nameUser} " );
    Console.WriteLine($"{nameUser} Escolha um Heroi:\r\n  \r\nCavaleiro!\r\n \r\nMago!\r\n \r\nNinja!\r\n \r\nLutador!\r\n ");
    string heroUser = Console.ReadLine();

    if (heroUser == "Cavaleiro")
     try {
    Console.WriteLine($"Otimo Você escolheu o Cavaleiro! Conheça seu Heroi: " + knight.Name +  " \r\nLevel:" +knight.Level +" \r\nVida:" + knight.Health + " \r\nForça:" + knight.StrengthAttack, "\r\n"  );
    Console.WriteLine($" \r\nEssa Não!! O {bossKnight.Name}  \r\nLevel:{bossKnight.Level} \r\nVida:{bossKnight.Health} \r\nEstilo:{bossKnight.HeroType} \r\nForça:{bossKnight.StrengthAttack}!! \r\n \r\nEle está atacando a guilda da GFT!!! Precisamos de Você Agora!! \r\nDigite Quanto de Dano Voce Deseja Causar ao Oponente: ");
   
    int DamageKnight = int.Parse(Console.ReadLine());
    if (DamageKnight > 300) 
    {
    System.Console.WriteLine("Voce não tem estamnia para realizar um ataque com mais de 300 de dano! \r\nEsse Descuido Causou sua Morte! \r\nGAME OVER!!!");
    }

    if(DamageKnight <= 300)
    {
    Console.WriteLine(knight.Attack(DamageKnight));
    System.Console.WriteLine("Parabens Voce Derrotou o Boss e Ajudou a Guilda da GFT!! Espero que eles te recompensem!!");
    }
    

    }catch (InvalidCastException e) {
    System.Console.WriteLine("Algo deu Errado!, Reinicie o Jogo! Codigo de Erro:"+ e );

    }
    

    else if (heroUser == "Mago")
    try {
    Console.WriteLine($"Otimo Você escolheu Mago! Conheça seu Heroi:  " + wizzard.Name + " \r\nLevel:" +wizzard.Level +" \r\nVida:" + wizzard.Health + " \r\nForça:" + wizzard.StrengthAttack, "\r\n" );
    Console.WriteLine($" \r\nEssa Não!! O {bossWizzard.Name} \r\n Level:{bossWizzard.Level}  \r\n Vida:{bossWizzard.Health} \r\nEstilo:{bossWizzard.HeroType}  \r\nForça:{bossWizzard.StrengthAttack}!! \r\n \r\nEle está atacando a guilda da GFT!!! \r\nPrecisamos de Você Agora!! \r\nDigite Quanto de Dano Voce Deseja Causar ao Oponente: ");
   
    int DamageKnight = int.Parse(Console.ReadLine());
    if (DamageKnight > 175) 
    {
    System.Console.WriteLine("Voce não tem estamnia para realizar um ataque com mais de 300 de dano! \r\nEsse Descuido Causou sua Morte! \r\nGAME OVER!!!");
    }

    if(DamageKnight <= 175) 
    {
    Console.WriteLine(wizzard.Attack(DamageKnight));
    System.Console.WriteLine("Parabens Voce Derrotou o Boss e Ajudou a Guilda da GFT!! Espero que eles te recompensem!!");    
    }

    }catch (InvalidCastException e) {
    System.Console.WriteLine("Algo deu Errado!, Reinicie o Jogo! Codigo de Erro:"+ e );

    }
    
    else if (heroUser == "Ninja")
    try {
    Console.WriteLine($"Otimo! Você escolheu o Ninja! Conheça seu Heroi: " + ninja.Name + " \r\nLevel:" +ninja.Level +" \r\nVida:" + ninja.Health + "\r\nForça:" + ninja.StrengthAttack, "\r\n"  );
    Console.WriteLine($" \r\nEssa Não!! O {bossNinja.Name} \r\nLevel:{bossNinja.Level} \r\nVida:{bossNinja.Health} \r\nEstilo:{bossNinja.HeroType}  \r\nForça:{bossNinja.StrengthAttack}!! \r\n \r\nEle está atacando a guilda da GFT!!! \r\nPrecisamos de Você Agora!! \r\nDigite Quanto de Dano Voce Deseja Causar ao Oponente: ");
   
    int DamageKnight = int.Parse(Console.ReadLine());
    if (DamageKnight > 150)
    {
    System.Console.WriteLine("Voce não tem estamnia para realizar um ataque com mais de 300 de dano! \r\nEsse Descuido Causou sua Morte! \r\nGAME OVER!!!");
    }
    if(DamageKnight <= 150)
    {
    Console.WriteLine(ninja.Attack(DamageKnight));
    System.Console.WriteLine("Parabens Voce Derrotou o Boss e Ajudou a Guilda da GFT!! Espero que eles te recompensem!!");
    }
 
    }catch (InvalidCastException e) {
    System.Console.WriteLine("Algo deu Errado!, Reinicie o Jogo! Codigo de Erro:"+ e );

    }
    

    else if (heroUser == "Lutador")
    try {
    Console.WriteLine($"Otimo Você escolheu o Lutador! Conheça seu Heroi " + fighter.Name + " \r\nLevel:" +fighter.Level +"\r\nVida:" + fighter.Health + "\r\nForça:" + fighter.StrengthAttack, "\r\n" );
    Console.WriteLine($" \r\nEssa Não!! O {bossFighter.Name} \r\nLevel:{bossFighter.Level} \r\nVida:{bossFighter.Health} \r\nEstilo:{bossFighter.HeroType} \r\nForça:{bossFighter.StrengthAttack}!!\r\n \r\nestá atacando a guilda da GFT!!! \r\nPrecisamos de Você Agora!!\r\n  \r\nDigite Quanto de Dano Voce Deseja Causar ao Oponente: ");
   
    int DamageFighter = int.Parse(Console.ReadLine());
    System.Console.WriteLine("\r\n");

    if (DamageFighter > 250)
    {
    System.Console.WriteLine("Voce não tem estamnia para realizar um ataque com mais de 250 de dano! \r\nEsse Descuido Causou sua Morte! \r\nGAME OVER!!! ");
    }

    if (DamageFighter <= 250)
    {
    Console.WriteLine(fighter.Attack(DamageFighter));
    System.Console.WriteLine("Parabens Voce Derrotou o Boss e Ajudou a Guilda da GFT!! Espero que eles te recompensem!!");
    }

    }catch (InvalidCastException e) {
    System.Console.WriteLine("Algo deu Errado!, Reinicie o Jogo! Codigo de Erro:"+ e );

    }
    else {
        System.Console.WriteLine("Ocorreu um erro, Lamentamos Muito!, Porfavor Reinicie O Jogo." );  
    }