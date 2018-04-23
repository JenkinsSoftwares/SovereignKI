using System;

namespace Sovereign
{
    public void DeadMethod
    {
        //int x = 1;
        //    Coordinates PotentialHitCoordinates = this._lastHitCoordinates;
        //    Heading ShootDirection;
        //    Random rnd = new Random( );

        //    if ( this._lastHitCoordinates.X > 0 && this._lastHitCoordinates.X < 9 && this._lastHitCoordinates.Y > 0 && this._lastHitCoordinates.Y < 9 && this._invertHeading != true )
        //    {
        //        var RandomArgument = rnd.Next( 0, 3 );
        //        if ( RandomArgument == 0 )
        //            ShootDirection = Heading.Up;
        //        else if ( RandomArgument == 1 )
        //            ShootDirection = Heading.Down;
        //        else if ( RandomArgument == 2 )
        //            ShootDirection = Heading.Right;
        //        else
        //            ShootDirection = Heading.Left;
        //    }
        //    else
        //    {
        //        ShootDirection = ShotOnEdge( );
        //    }

        //    if ( this._invertHeading == true )
        //    {
        //        x = 2;
        //            switch ( this._headingToRefer )
        //            {
        //                case Heading.Left:
        //                    var RandomArgument = rnd.Next( 0, 2 );
        //                    if ( RandomArgument == 0 )
        //                        ShootDirection = Heading.Up;
        //                    else if ( RandomArgument == 1 )
        //                        ShootDirection = Heading.Down;
        //                    else if ( RandomArgument == 2 )
        //                        ShootDirection = Heading.Right;
        //                break;
        //                case Heading.Right:
        //                    RandomArgument = rnd.Next( 0, 2 );
        //                    if ( RandomArgument == 0 )
        //                        ShootDirection = Heading.Up;
        //                    else if ( RandomArgument == 1 )
        //                        ShootDirection = Heading.Down;
        //                    else if ( RandomArgument == 2 )
        //                        ShootDirection = Heading.Left;
        //                break;
        //                case Heading.Up:
        //                    RandomArgument = rnd.Next( 0, 2 );
        //                    if ( RandomArgument == 0 )
        //                        ShootDirection = Heading.Left;
        //                    else if ( RandomArgument == 1 )
        //                        ShootDirection = Heading.Down;
        //                    else if ( RandomArgument == 2 )
        //                        ShootDirection = Heading.Right;
        //                break;
        //                case Heading.Down:
        //                      RandomArgument = rnd.Next( 0, 2 );
        //                        if ( RandomArgument == 0 )
        //                            ShootDirection = Heading.Up;
        //                        else if ( RandomArgument == 1 )
        //                            ShootDirection = Heading.Left;
        //                        else if ( RandomArgument == 2 )
        //                            ShootDirection = Heading.Right;

        //                break;
        //            }

        //    }

        //    PotentialHitCoordinates.PointOfAim = ShootDirection;
        //    this._headingToRefer = PotentialHitCoordinates.PointOfAim;


        //    switch ( PotentialHitCoordinates.PointOfAim )
        //    {
        //        case Heading.Left:
        //            PotentialHitCoordinates.X = PotentialHitCoordinates.X - x;
        //            break;
        //        case Heading.Right:
        //            PotentialHitCoordinates.X = PotentialHitCoordinates.X + x;
        //            break;
        //        case Heading.Up:
        //            PotentialHitCoordinates.Y = PotentialHitCoordinates.Y - x;
        //            break;
        //        case Heading.Down:
        //            PotentialHitCoordinates.Y = PotentialHitCoordinates.Y + x;
        //            break;
        //    }
        //    this._coordinatesToRefer = PotentialHitCoordinates;
        //    if ( this._deepSea.AlreadyShotCoordinates.Any( a=> a.X == PotentialHitCoordinates.X && a.Y == PotentialHitCoordinates.Y) )
        //    {
        //        return null;
        //    }

        //    return PotentialHitCoordinates;
        //}
    }
    internal class Ship_Graveyard
    {
        //         try
        //            {
        //            private Heading ShootDirection = Heading.Down;
        //        private Coordinates PotentialHitCoordinates = this._lastHitCoordinates;

        //        private Random rnd = new Random( );
        //                if ( this._barrage == true )
        //                    ShootDirection = this._headingToRefer;
        //                else if ( this._invertHeading == true )
        //                {
        //                    Debug.WriteLine( "Using reference Heading" );
        //                    switch ( this._headingToRefer )
        //                    {
        //                        case Heading.Left:
        //                            ShootDirection = Heading.Right;
        //                            break;

        //                        case Heading.Right:
        //                            ShootDirection = Heading.Left;
        //                            break;

        //                        case Heading.Up:
        //                            ShootDirection = Heading.Down;
        //                            break;

        //                        case Heading.Down:
        //                            ShootDirection = Heading.Up;
        //                            break;
        //                    }

        //                else
        //                {
        //                    Debug.WriteLine( "Searching a random Heading" );
        //                    var RandomArgument = rnd.Next( 0, 3 );
        //                    if ( RandomArgument == 0 && PotentialHitCoordinates.Y > 0 )
        //                        ShootDirection = Heading.Up;
        //                    else if ( RandomArgument == 1 && PotentialHitCoordinates.Y< this._internalSize )
        //                        ShootDirection = Heading.Down;
        //                    else if ( RandomArgument == 2 && PotentialHitCoordinates.X< this._internalSize )
        //                        ShootDirection = Heading.Right;
        //                    else if ( PotentialHitCoordinates.X > 0 )
        //                        ShootDirection = Heading.Left;
        //                }
        //                switch ( ShootDirection )
        //                {
        //                    case Heading.Left:
        //                        if ( PotentialHitCoordinates.X > 0 )
        //                            PotentialHitCoordinates.X = PotentialHitCoordinates.X - 1;
        //                        if ( this._invertHeading == true )
        //                        {
        //    ShootDirection = Heading.Right;
        //    PotentialHitCoordinates.X = PotentialHitCoordinates.X + 2;
        //}
        //                        if ( PotentialHitCoordinates.Y > 0 )
        //                        {
        //    ShootDirection = Heading.Right;
        //    PotentialHitCoordinates.X = PotentialHitCoordinates.X + 1;
        //}

        //                        break;

        //                    case Heading.Right:
        //                        if ( PotentialHitCoordinates.X < this._internalSize )
        //                            PotentialHitCoordinates.X = PotentialHitCoordinates.X + 1;
        //                        if ( this._invertHeading == true )
        //                        {
        //    ShootDirection = Heading.Left;
        //    PotentialHitCoordinates.X = PotentialHitCoordinates.X - 2;
        //}
        //                        else if ( PotentialHitCoordinates.X > this._internalSize )
        //                        {
        //    ShootDirection = Heading.Left;
        //    PotentialHitCoordinates.X = PotentialHitCoordinates.X - 1;
        //}
        //                        break;

        //                    case Heading.Up:
        //                        if ( PotentialHitCoordinates.Y > 0 )
        //                            PotentialHitCoordinates.Y = PotentialHitCoordinates.Y - 1;
        //                        if ( this._invertHeading == true )
        //                        {
        //    ShootDirection = Heading.Down;
        //    PotentialHitCoordinates.Y = PotentialHitCoordinates.Y + 2;
        //}
        //                        else if ( PotentialHitCoordinates.Y < 1 )
        //                        {
        //    ShootDirection = Heading.Down;
        //    PotentialHitCoordinates.Y = PotentialHitCoordinates.Y + 1;
        //}
        //                        break;

        //                    case Heading.Down:
        //                        if ( PotentialHitCoordinates.Y < this._internalSize )
        //                            PotentialHitCoordinates.Y = PotentialHitCoordinates.Y + 1;
        //                        if ( this._invertHeading == true )
        //                        {
        //    ShootDirection = Heading.Up;
        //    PotentialHitCoordinates.Y = PotentialHitCoordinates.Y - 2;
        //}
        //                        else if ( PotentialHitCoordinates.Y > this._internalSize )
        //                        {
        //    ShootDirection = Heading.Up;
        //    PotentialHitCoordinates.Y = PotentialHitCoordinates.Y - 1;
        //}
        //                        break;
        //}

        //                this._coordinatesToRefer = PotentialHitCoordinates;
        //                this._headingToRefer = ShootDirection;
        //                if ( this._deepSea.AlreadyShotCoordinates.Any( a => a.X == PotentialHitCoordinates.X && a.Y == PotentialHitCoordinates.Y ))
        //                    return null;

        //                this._deepSea.AlreadyShotCoordinates.Add( PotentialHitCoordinates );

        //                return PotentialHitCoordinates;
        //}
        //            catch ( Exception )
        //            {
        //                throw;
        //            }
        //    }
    }
}