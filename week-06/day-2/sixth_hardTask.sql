/*For all cases where the same reviewer rated the same movie twice and gave it a higher rating the second time, return the reviewer's name and the title of the movie.*/
SELECT reviewer.name, movie.title
FROM movie INNER JOIN rating a, rating b
ON movie.mID = a.mID
INNER JOIN reviewer
ON a.rID = reviewer.rID
AND a.mID = b.mID AND a.rID = b.rID AND a.stars<b.stars AND a.ratingdate<b.ratingdate;
