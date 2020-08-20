using System;
namespace ClassesExercise
{
    public class Vector2
    {
        public float x;
        public float y;

        public float GetDistanceTo(Vector2 otherVec)
        {
            float distance = 0f;
            float doubleX = (otherVec.x - x) * 2;
            float doubleY = (otherVec.y - y) * 2;
            distance = (float)(Math.Sqrt(doubleX + doubleY));
            return distance;
        }
    }
}
