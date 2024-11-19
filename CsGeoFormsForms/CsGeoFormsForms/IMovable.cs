namespace CsGeoFormsForms
{
    interface IMovable
    {
        /// <summary>
        /// Moves the object a certain amount of pixels in a given direction
        /// </summary>
        /// <param name="aDistanceX">Amount of pixels to move in X-Direction</param>
        /// <param name="aDistanceY">Amount of pixels to move in Y-Direction</param>
        void MoveRelative(int aDistanceX, int aDistanceY);
        /// <summary>
        /// Moves the object to a specific position
        /// </summary>
        /// <param name="aPosition">The position to move to</param>
        void MoveAbsolute(Point aPosition);
    }
}
