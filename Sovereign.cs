using System;
using System.Collections.Generic;
using System.Linq;
using BattleSDK;

namespace Sovereign
{
    // KI - Mainclass Version 1.4
    public class Sovereign : BattleshipKI
    {
        #region private
        private Battleground _deepSea;
        private Battleground _ownSea;
        private int _fieldSize;
        private Gardian _thanix;
        private List<Ship> ShipsAlreadyPlaced = new List<Ship>( );
        #endregion
        public Sovereign( int size ) : base( size )
        {
            try
            {
                string KiTitle = GetName( );
                if ( size != -1 )
                {
                    this._deepSea = new Battleground( size );
                    this._ownSea = new Battleground(size);
                    this._fieldSize = size;
                    this._thanix = new Gardian( this._fieldSize, this._deepSea );
                }
            }
            catch ( Exception )
            {
                throw;
            }
        }

        public override string GetName( )
        {
            return "Sovereign";
        }

        public override void Notify( int x, int y, bool hit, bool deadly )
        {
            this._thanix.ShotManager( new Coordinates( x, y ), hit, deadly );
        }

        public override void SetShips( List<Ship> ships )
        {
            try
            { 
            
                Random random = new Random( );
                foreach ( var ship in ships )
                {
                    this._thanix.ShipLengths.Add( ship.Size );
                    do
                    {
                        ship.Dir = GetDirection( );
                        switch ( ship.Dir )
                        {
                            case Direction.HORIZONTAL:
                                ship.X = random.Next( 0, this._fieldSize - ship.Size );
                                ship.Y = random.Next( 0, this._fieldSize );
                                break;

                            case Direction.VERTICAL:
                                ship.X = random.Next( 0, this._fieldSize );
                                ship.Y = random.Next( 0, this._fieldSize - ship.Size );
                                break;
                        }
                    } while ( CanSetShip( ship ) == false );
                    ship.Dir = GetDirection( );
                    ShipsAlreadyPlaced.Add( ship );
                }
            }
            catch ( Exception )
            {
                throw;
            }
        }

        public Direction GetDirection( )
        {
            Random rndHeading = new Random( );

            if ( rndHeading.Next( 0, 2 ) == 0 )
                return Direction.HORIZONTAL;
            else
                return Direction.VERTICAL;
        }

        public override void Shoot( out int x, out int y )
        {
            Coordinates shot;
            switch ( this._thanix.Mode )
            {
                case Models.TargetingMode.ByChance:
                    shot = this._thanix.ShootByChance( );
                    break;

                case Models.TargetingMode.Deliberately:
                    shot = this._thanix.ShootDeliberately( );
                    break;

                default:
                    shot = this._thanix.ShootByChance( );
                    break;
            }
            x = shot.X;
            y = shot.Y;
        }

        private bool CanSetShip( Ship shipToSet )
        {
            List<Coordinates> CoordinatesToValidate = new List<Coordinates>( );

            switch ( shipToSet.Dir )
            {
                case Direction.HORIZONTAL:
                    for ( int i = 0; i < shipToSet.Size; i++ )
                        CoordinatesToValidate.Add( new Coordinates( shipToSet.X + i, shipToSet.Y ) );
                    break;

                case Direction.VERTICAL:
                    for ( int i = 0; i < shipToSet.Size; i++ )
                        CoordinatesToValidate.Add( new Coordinates( shipToSet.X, shipToSet.Y + i ) );
                    break;
            }

            List<Coordinates> CoordinatesOfPlacedShips = new List<Coordinates>( );
            if ( ShipsAlreadyPlaced.Count != 0 )
            {
                foreach ( var ship in ShipsAlreadyPlaced )
                {
                    switch ( ship.Dir )
                    {
                        case Direction.HORIZONTAL:
                            for ( int i = 0; i < ship.Size; i++ )
                            {
                                CoordinatesOfPlacedShips.Add( new Coordinates( ship.X + i, ship.Y ) );
                            }
                            break;

                        case Direction.VERTICAL:
                            for ( int i = 0; i < ship.Size; i++ )
                            {
                                CoordinatesOfPlacedShips.Add( new Coordinates( ship.X, ship.Y + i ) );
                            }
                            break;
                    }
                }
                try
                {
                    for ( int i = 0; i < CoordinatesToValidate.Count; i++ )
                    {
                        if ( CoordinatesOfPlacedShips.Any( a => a.Equals( CoordinatesToValidate[i] ) ) )
                        {
                            return false;
                        }
                    }
                }
                catch ( Exception )
                {
                    throw new ArgumentOutOfRangeException( "Check dis" );
                }
            }

            return true;
        }
    }
}