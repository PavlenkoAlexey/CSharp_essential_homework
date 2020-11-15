using System;

namespace Task_2
{
    class Pupil
    {
        public string Name { get; set; }

        public Pupil(string name) => Name = name;
        public virtual void Study()
        {
            Console.WriteLine("Учится");
        }
        public virtual void Read()
        {
            Console.WriteLine("Читает");
        }
        public virtual void Write()
        {
            Console.WriteLine("Пишет");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Отдыхает");
        }

    }
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base(name) { }
        public override void Study()
        {
            Console.WriteLine("Учится на пятёрочку");
        }
        public override void Read()
        {
            Console.WriteLine("Читает много полезного");
        }
        public override void Write()
        {
            Console.WriteLine("Пишет красиво и грамотно ");
        }
        public override void Relax()
        {
            Console.WriteLine("Отдыхает мало но качественно");
        }
    }
    class GoodPupil : Pupil 
    {
        public GoodPupil(string name) : base(name) { }
        public override void Study()
        {
            Console.WriteLine("Учится на 4");
        }
        public override void Read()
        {
            Console.WriteLine("Читает что задали");
        }
        public override void Write()
        {
            Console.WriteLine("Пишет неплохо, в основном без ошибок");
        }
        public override void Relax()
        {
            Console.WriteLine("Тратит лишнее время на развлечения");
        }
    }
    class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name) { }
        public override void Study()
        {
            Console.WriteLine("Учится на двойки-тройки");
        }
        public override void Read()
        {
            Console.WriteLine("Иногда читает состав освежителя воздуха");
        }
        public override void Write()
        {
            Console.WriteLine("Пишет криво и с ошибками");
        }
        public override void Relax()
        {
            Console.WriteLine("Не жизнь а сплошной чилл");
        }
    }
}
