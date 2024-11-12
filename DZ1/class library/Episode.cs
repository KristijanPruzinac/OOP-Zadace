using System;
using System.Runtime.CompilerServices;

public class Episode
{
	private int ViewerCount { get; set; }
	private double RatingSum { get; set; }
	private double BestRating { get; set; }

    public Episode() : this(0, 0, 0) { }

    public Episode(int ViewerCount, double RatingSum, double BestRating)
	{
		this.ViewerCount = ViewerCount;
		this.RatingSum = RatingSum;
		this.BestRating = BestRating;
	}

	public int GetViewerCount()
	{
		return ViewerCount;
	}

	public double GetAverageScore()
	{
		return RatingSum / ViewerCount;
	}

	public double GetMaxScore()
	{
		return BestRating;
	}

	public void AddView(double score)
	{
		if (score >= 0.0 && score <= 10.0)
		{
			RatingSum += score;
            BestRating = Math.Max(BestRating, score);

            ViewerCount++;
		}
	}
}
