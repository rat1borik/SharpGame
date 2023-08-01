namespace SharpGame {
	public abstract class Armor {
		public int Thickness { get; } //cm
		public string Type { get; }

		public Armor(int thickness, string type) {
			Thickness = thickness;
			Type = type;
		}

		public override string ToString() => $"Броня типа {Type} толщина {Thickness} cм";

		public abstract bool IsPenetrated(Ammo projectile);

	}

	public class TitanArmor : Armor {
		public TitanArmor(int thickness) : base(thickness, "титановая") { }

		public override bool IsPenetrated(Ammo projectile) {

			if (projectile is FugasAmmo) return projectile.GetPenetration() * 0.5 > Thickness;
			else if (projectile is FragileAmmo) return projectile.GetPenetration() > Thickness;
			else if (projectile is MegaAmmo) return projectile.GetPenetration() * 1.5 > Thickness;

			return false;
		}

	}

	public class CarbidArmor : Armor {
		public CarbidArmor(int thickness) : base(thickness, "карбидная") { }

		public override bool IsPenetrated(Ammo projectile) {

			if (projectile is FugasAmmo) return projectile.GetPenetration() * 1.5 > Thickness;
			else if (projectile is FragileAmmo) return projectile.GetPenetration() * 0.5 > Thickness;
			else if (projectile is MegaAmmo) return projectile.GetPenetration() > Thickness;

			return false;
		}

	}

	public class PaperArmor : Armor {
		public PaperArmor(int thickness) : base(thickness, "картонная") { }

		public override bool IsPenetrated(Ammo projectile) {

			if (projectile is FugasAmmo) return projectile.GetPenetration() > Thickness;
			else if (projectile is FragileAmmo) return projectile.GetPenetration() * 1.5 > Thickness;
			else if (projectile is MegaAmmo) return projectile.GetPenetration() * 0.5 > Thickness;

			return false;
		}

	}
}