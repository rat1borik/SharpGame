
namespace SharpGame {
	public class Gun {

		public const int BaseCaliber = 40;
		public int Caliber { get; } //mm
		public int BarrelLength { get; } //m
		public Gun(int cal, int barLength) {
			Caliber = cal;
			BarrelLength = barLength;
		}

		public bool IsHit() => BarrelLength + Random.Shared.Next(0, 100) > 60;

	}

}
