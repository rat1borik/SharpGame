using System;

namespace SharpGame;

public class Global {
	public static void Main() {
		Gun g = new Gun(50, 2);
		FugasAmmo fugas = new FugasAmmo(g);

		PaperArmor paperArmor = new PaperArmor(1000);

		if (g.IsHit()) {
			Console.WriteLine("Попав");
			if (paperArmor.IsPenetrated(fugas)) {
				Console.WriteLine("Разъебалово");
			}
			else {
				Console.WriteLine("Не пробил");
			}
		}
		else {
			Console.WriteLine("ЛОх");
		}

		Console.WriteLine(fugas.ToString());
		Console.ReadLine();
	}
}

