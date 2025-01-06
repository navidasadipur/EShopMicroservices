
# .NET 8 Microservices: DDD, CQRS, Clean Architecture

This repository contains my implementation of the `.NET 8 Microservices: DDD, CQRS, Vertical/Clean Architecture` course, where I followed the instructor's guidance and wrote code along with the lessons. The course provided a comprehensive introduction to building scalable, maintainable microservices using the latest .NET technologies and best practices.

## What I Learned

### Microservices Architecture
- Learned to design modular services for an e-commerce platform, including Catalog, Basket, Discount, and Ordering services.
- Gained hands-on experience with **Domain-Driven Design (DDD)** principles and **Clean Architecture** for a layered application structure.
- Explored the **CQRS** pattern and implemented it using **MediatR** for separation of concerns and efficient command/query handling.

### Technologies and Tools
- **.NET 8** and **C# 12**: Learned to build minimal APIs and Web APIs using the latest features.
- **Docker** and **Docker Compose**: Gained practical knowledge of containerizing microservices and orchestrating multi-container environments.
- **RabbitMQ** and **MassTransit**: Implemented asynchronous communication between microservices.
- **Redis**: Used as a distributed cache for the Basket service.
- **gRPC**: Built performant inter-service communication using Protocol Buffers.
- **PostgreSQL**, **SQLite**, and **SQL Server**: Worked with relational and NoSQL databases, including migrations and transactional support.
- **YARP API Gateway**: Learned to implement API routing and gateway patterns with reverse proxy.

### Key Features
- Followed the instructor’s guidance to develop vertical slice architecture using feature folders.
- Integrated cross-cutting concerns such as logging, exception handling, and health checks.
- Applied design patterns like **Decorator**, **Proxy**, and **Cache-Aside** for cleaner, reusable code.
- Built a shopping web application using Razor pages and Bootstrap, consuming APIs via the **Refit** library.
- Orchestrated services with Docker Compose, managing environment variables and container dependencies.

This repository is part of my learning journey. It demonstrates my hands-on experience with modern microservices architecture, guided by the `.NET 8 Microservices` course, and showcases the skills and concepts I have acquired throughout the lessons.
