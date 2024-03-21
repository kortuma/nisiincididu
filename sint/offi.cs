// Create a repository object that handles products
ProductRepository repo = new ProductRepository();

// Add some products to the repository
repo.Add(new Product("Apple", 1.99));
repo.Add(new Product("Banana", 0.99));
repo.Add(new Product("Carrot", 0.49));

// Remove all the products from the repository
repo.RemoveAll();

// Check the count of the repository
Console.WriteLine(repo.Count); // Output: 0
