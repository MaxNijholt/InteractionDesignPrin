namespace SudokuBasic {
	public class Wrapper {
		public Sudoku.IGame myGame = new Sudoku.Game( );
		public Wrapper ( ) {
		}

		public void Create ( ) {
			myGame.create( );
		}

		public bool Set ( short x, short y, short value ) {
			int lel;
			myGame.set( x, y, value, out lel );
			return lel == 1;
		}

		public short Get ( short x, short y ) {
			short val;
			myGame.get( x, y, out val );
			return val;
		}

		public bool IsValid ( ) {
			int valid;
			myGame.isValid(out valid);
			return valid == 1;
		}

		public bool Read ( ) {
			int done;
			myGame.read( out done );
			return done == 1;
		}

		public bool Write ( ) {
			int write;
			myGame.write( out write );
			return write == 1;
		}

		public void Hint (out short x, out short y, out short val, out int succeeded) {
			myGame.hint( out x, out y, out val, out succeeded );
		}
	}
}
