namespace SharpGame {
	public abstract class Ammo {

		public const int BaseDamage = 5;
		public string Type { get; }
		public Gun Gun { get; }
		public Ammo(Gun someGun, string type) {
			Gun = someGun;
			Type = type;
		}

		public virtual int GetDamage() => Gun.Caliber * BaseDamage;

		public int GetPenetration() => Gun.Caliber * 2;

		public override string ToString() => $"Снаряд типа {Type} к пушке {Gun.Caliber} мм / {Gun.BarrelLength} м";
	}

	public class FugasAmmo : Ammo {
		public FugasAmmo(Gun gun) : base(gun, "фугасный") { }
	}

	public class FragileAmmo : Ammo {
		public FragileAmmo(Gun gun) : base(gun, "осколочный") { }

		public override int GetDamage() => (int)Math.Ceiling(base.GetDamage() * 0.6);
	}

	public class MegaAmmo : Ammo {
		public MegaAmmo(Gun gun) : base(gun, "сильный") { }

		public override int GetDamage() => (int)Math.Ceiling(base.GetDamage() * 1.3 + 50);
	}
}