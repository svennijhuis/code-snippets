var result = await _carsCollection
    .UpdateOneAsync(
        car => car.Id == identifier,
        Builders<Car>.Update
            .Set(car => car.IsSold, true)
            .Set(car => car.SoldDate, DateTime.UtcNow)
            .Set(car => car.UpdatedDate, DateTime.UtcNow));
