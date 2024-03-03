namespace ChallengeApp
{
    public class Supervisor : Employee
    {
        public Supervisor(string firstName, string lastName, char gender, int age)
        : base(firstName, lastName, gender, age)
        {
        }
    
        new public void AddPoints(string score)
        {
            string scoreTmp = score;
            int gradeHalf = 0;
            int grade = 0;
            if (score.Length == 2)
            {
                if (score.Contains('-'))
                {
                    gradeHalf = -5;
                    scoreTmp = scoreTmp.Replace("-", "");
                }
                else if (score.Contains('+'))
                {
                    gradeHalf = 5;
                    scoreTmp = scoreTmp.Replace("+", "");
                }
            }
            if ( scoreTmp.Length == 1 && "123456".Contains(scoreTmp[0]) 
                                      && int.TryParse(scoreTmp, out grade) )
            {
//                points = (grade - 1) * 20 + gradeHalf;
                this.AddPoints((grade - 1) * 20 + gradeHalf);
            }
            else
            {
                throw new Exception("score " + '"' + score + '"' + " is not proper score");
            }

            //switch (score)
            //{
            //    case "6":
            //        this.AddPoints(100);
            //        break;
            //    case 'B':
            //    case 'b':
            //        this.AddPoints(80);
            //        break;
            //    case 'C':
            //    case 'c':
            //        this.AddPoints(60);
            //        break;
            //    case 'D':
            //    case 'd':
            //        this.AddPoints(40);
            //        break;
            //    case 'E':
            //    case 'e':
            //        this.AddPoints(20);
            //        break;
            //    default:
            //        this.AddPoints(0);
            //        break;
            //}

            //if (score.Length == 1)
            //    this.AddPoints(score[0]);
            //else if (float.TryParse(score, out float result))
            //    this.AddPoints((float)result);
            //else
            //    throw new Exception("score " + '"' + score + '"' + " is not proper score");
        }
    }
}
