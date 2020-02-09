﻿using DefaultEcs.Technical.Command;

namespace DefaultEcs
{
    /// <summary>
    /// Provides a set of methods to help the generation of generic code for AoT compilation.
    /// </summary>
    public static class AoTHelper
    {
        /// <summary>
        /// Registers the type <typeparamref name="T"/> so <see cref="SubscribeAttribute"/> can freely be used on method like the delegate <see cref="ActionIn{T}"/> to automatically subscribe when using <see cref="IPublisherExtension"/> on a <see cref="World"/> instance.
        /// </summary>
        /// <typeparam name="T">The type of message.</typeparam>
        public static void RegisterMessage<T>()
        {
            using World world = new World();

            world.Subscribe(default(ActionIn<T>));
        }

        /// <summary>
        /// Registers the type <typeparamref name="T"/> so it can freely be used in <see cref="System.ComponentAttribute"/>.
        /// </summary>
        /// <typeparam name="T">The type of component.</typeparam>
        public static void RegisterComponent<T>()
        {
            new EntitySetBuilder(default, default)
                .With<T>().WithEither<T>().Or<T>().WithEither<T>().With<T>()
                .Without<T>().WithoutEither<T>().Or<T>().WithoutEither<T>().Without<T>()
                .WhenAdded<T>().WhenAddedEither<T>().Or<T>().WhenAddedEither<T>().WhenAdded<T>()
                .WhenChanged<T>().WhenChangedEither<T>().Or<T>().WhenChangedEither<T>().WhenChanged<T>()
                .WhenRemoved<T>().WhenRemovedEither<T>().Or<T>().WhenRemovedEither<T>().WhenRemoved<T>();
        }

        /// <summary>
        /// Registers the unmanaged type <typeparamref name="T"/> so it can freely be used in <see cref="System.ComponentAttribute"/> and by <see cref="Command.EntityRecord.Set{T}(in T)"/>.
        /// </summary>
        /// <typeparam name="T">The type of component.</typeparam>
        public static void RegisterUnmanagedComponent<T>()
            where T : unmanaged
        {
            RegisterComponent<T>();

            using World world = new World();

            Entity entity = world.CreateEntity();

            unsafe
            {
                T value;

                UnmanagedComponentCommand<T>.WriteComponent(default, (byte*)&value, default);
                UnmanagedComponentCommand<T>.SetComponent(entity, default, (byte*)&value);
            }
        }
    }
}
