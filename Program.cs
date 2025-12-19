
using Microsoft.EntityFrameworkCore;
using TestMigrations.Data.Context;
using TestMigrations.Data.Entiteies;
AppDbContexts _context = new();
//Teachers teachers = new();
//Console.WriteLine(_context.Entry(teachers).State);

//Teachers teachers1 = new()
//{
//    Name="Ali",
//    Description="Kimya"
//};
//Console.WriteLine(_context.Entry(teachers1).State);
//_context.Teachers.Add(teachers1);
//Console.WriteLine(_context.Entry(teachers1).State);
//_context.SaveChanges();
//Console.WriteLine(_context.Entry(teachers1).State);

//Teachers teachers2 = new()
//{
//    Name = "Zeynal",
//    Description = "Kimya"
//};

//Console.WriteLine(_context.Entry(teachers2).State);
//_context.Teachers.Add(teachers2); 
//Console.WriteLine(_context.Entry(teachers2).State);

//_context.Teachers.Find(1);

//_context.SaveChanges();

//Ramda var DB de yoxdur Changed Traced olur Datached
//Ramdada var ve DB dede varsa ve aralarinda ferq varsa Modifield statedir
//Eger Add etsem yeni insert etsem onda Added state edir

//Teachers t1 = new()
//{
//    Name="Seyid",
//    Description="Fizika",
//    Mail="sy@mailru"
//};
//Console.WriteLine(_context.Entry(t1).State);
//_context.Teachers.Add(t1);
//Console.WriteLine(_context.Entry(t1).State);
//_context.SaveChanges();
//Console.WriteLine(_context.Entry(t1).State);

//Teachers? teachers = _context.Teachers.Find(1);
//Console.WriteLine(_context.Entry(teachers).State);
//teachers.Name = "Zeynal";
//Console.WriteLine(_context.Entry(teachers).State);
//_context.SaveChanges();
//Console.WriteLine(_context.Entry(teachers).State);
//Add,AddRange
//Add bir obyekti add edirik,AddRange birden cox obyekti Add edirik
//Generic Add butun obyektler ucun ortaq Add yazirsan

//Teachers t1 = new()
//{
//    Name = "Eli",
//    Description = "Tarix",
//    Mail="aa@mailru"
//};
//Teachers t2 = new()
//{
//    Name = "Ulvi",
//    Description = "Kimya",
//    Mail = "tt@mailru"
//};
//_context.Teachers.AddRange(t1,t2);//Birden cox obyekt ucun
//_context.SaveChanges();

//Mene gelen obyekt bilinmir hansi tipdir db de olan butun entity ucun islemesi ucun ortaq ADd yaradaq
//_context.Entry(t2).State = EntityState.Added;
//_context.SaveChanges();
//_context.Add(t2);
//_context.SaveChanges();

#region Update

//Teachers ?teachers = _context.Teachers.Find(5);
//teachers.Name = "Firudun";
//_context.Teachers.Update(teachers);
//_context.SaveChanges();

//var t1 = new Teachers
//{
//    ID = 2,
//    Name = "Seyfu",
//    Description = "Fizika",
//    Mail="ttssdd"
//};
////_context.Entry(t1).State = EntityState.Modified;
//_context.Update(t1);
//_context.SaveChanges();

//Birden cox seyi update etmek
//_context.Teachers.Where(x => x.ID > 2)
//    .ExecuteUpdate(x => x
//      .SetProperty(st => st.Mail, st => "Yoxdur"));
//BulkUpdate yeni birden cox datani update edir ve savechanges istifade olunmur//
// birdefelik dbdeye sorgu atir db uzerinde duzelis edir


#endregion

#region Delete

//var t1 = new Teachers
//{
//    ID = 2,
//    Name = "Seyfu",
//    Description = "Fizika",
//    Mail = "ttssdd"
//};

//_context.Entry(t1).State=EntityState.Deleted;
//_context.Remove(t1);
//_context.SaveChanges();
////_context.Teachers.Where(x => x.ID > 2)
////    .ExecuteDelete();
//#endregion

//Teachers teachers = new Teachers()
//{

//    Name="Zeyneb",
//    Description="Idman",
//    Mail="sss"
//};
//Teachers teachers1 = new Teachers()
//{

//    Name = "Zeyneb",
//    Description = "Idman",
//    Mail = "sss"
//};
//Teachers teachers2 = new Teachers()
//{

//    Name = "Zeyneb",
//    Description = "Idman",
//    Mail = "sss"
//};
//Teachers teachers3 = new Teachers()
//{

//    Name = "Zeyneb",
//    Description = "Idman",
//    Mail = "sss"
//};




//_context.Teachers.Where(s => s.ID == 15)
//    .ExecuteUpdate(s => s
//     .SetProperty(st => st.Name, st => "Ali"));
//_context.Teachers.Where(s => s.ID == 15)
//    .ExecuteDelete();
//Console.WriteLine(_context.Teachers.Entry().State);


//_context.AddRange(teachers,teachers1,teachers2,teachers3);
//Console.WriteLine(_context.Teachers.Entry(teachers).State);
//_context.SaveChanges();
//Console.WriteLine(_context.Teachers.Entry(teachers).State);
//Teachers teachers1 = new Teachers()
//{
//    Name = "Fazil",
//    Description = "Seyfullah",
//    Mail = "fjdnfjdnd"
//};
//_context.Entry(teachers).State = EntityState.Deleted;
//_context.Remove(teachers); 
//_context.SaveChanges();
//Console.WriteLine(_context.Teachers.Entry(teachers).State);
//_context.AddRange(teachers,teachers1);
//Console.WriteLine(_context.Teachers.Entry(teachers).State);
//_context.SaveChanges();
//Console.WriteLine(_context.Teachers.Entry(teachers).State);

#endregion


///////////////////////////////////Added///////////////////////////
//Teachers t1 = new()
//{
//    Name = "Fazil",
//    Description = "Firudun",
//    Mail = "kfmdkmfk"
//};
//Teachers t2 = new()
//{
//    Name = "Seyid",
//    Description = "Firudun",
//    Mail = "kfmdkmfk"
//};

////_context.Teachers.AddRange(t1,t2);
//Console.WriteLine(_context.Teachers.Entry(t1).State);
////_context.SaveChanges();
////Console.WriteLine(_context.Teachers.Entry(t1).State);

//_context.Entry(t1).State = EntityState.Added;
//Console.WriteLine(_context.Teachers.Entry(t1).State);
//_context.SaveChanges();
//Console.WriteLine(_context.Teachers.Entry(t1).State);


/////////////////////////Modifield/////////////////
///

//Teachers t1 = new()
//{
//    ID=17,
//    Name = "Seyfullah",
//    Description = "Firudun",
//    Mail = "kfmdkmfk"
//};
//Console.WriteLine(_context.Teachers.Entry(t1).State);
//_context.Update(t1);
//Console.WriteLine(_context.Teachers.Entry(t1).State);
//_context.SaveChanges();
//Console.WriteLine(_context.Teachers.Entry(t1).State);

//_context.Teachers.Where(s => s.ID > 15)
//    .ExecuteUpdate(s => s
//    .SetProperty(st => st.Description, st => "Yooxdur"));

//////////////////////Deleted/////////////////

//Teachers?t1=  _context.Teachers.Find(14);
//Console.WriteLine(_context.Teachers.Entry(t1).State);
//_context.Teachers.Remove(t1);
//Console.WriteLine(_context.Teachers.Entry(t1).State);
//_context.SaveChanges();
//Console.WriteLine(_context.Teachers.Entry(t1).State);

_context.Teachers.Where(s => s.ID == 16)
    .ExecuteDelete();

////////////////////////////////////