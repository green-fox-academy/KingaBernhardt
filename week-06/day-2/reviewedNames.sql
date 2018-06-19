/*Find the names of all reviewers who rated Gone with the Wind. 
 */
SELECT DISTINCT reviewer.name
FROM reviewer, movie, rating
ON reviewer.rID = rating.rID
WHERE movie.mID = 101
AND movie.mID = rating.mID;
