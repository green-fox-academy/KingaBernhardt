SELECT r.name FROM reviewer r, rating WHERE r.rID = rating.rID AND rating.ratingdate IS NULL;
