namespace UnitTestProject1
{
    using System;

    using ClassLibrary1;

    using NUnit.Framework;

    [TestFixture]
    public class RemoveDuplicatesTests
    {
        [Test]
        public void When0_Returns0()
        {
            var sut = new RemoveDuplicatesFromSortedArray();

            var nums = new int[0]{};
            var result = sut.RemoveDuplicates(nums);

            ShowArray(nums);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void When1_Returns1()
        {
            var sut = new RemoveDuplicatesFromSortedArray();

            var nums = new int[]{2};
            var result = sut.RemoveDuplicates(nums);

            ShowArray(nums);
            Assert.That(result, Is.EqualTo(1));
            Assert.That(nums[0], Is.EqualTo(2));
        }

        [Test]
        public void When01_Returns2()
        {
            var sut = new RemoveDuplicatesFromSortedArray();

            var nums = new int[]{0,1};
            var result = sut.RemoveDuplicates(nums);

            ShowArray(nums);
            Assert.That(result, Is.EqualTo(2));
            Assert.That(nums[1], Is.EqualTo(1));
        }

        [Test]
        public void When11_Returns1()
        {
            var sut = new RemoveDuplicatesFromSortedArray();

            var nums = new int[]{1,1};
            var result = sut.RemoveDuplicates(nums);

            ShowArray(nums);
            Assert.That(result, Is.EqualTo(1));
            Assert.That(nums[0], Is.EqualTo(1));
        }

        [Test]
        public void When112_Returns2()
        {
            var sut = new RemoveDuplicatesFromSortedArray();

            var nums = new int[]{1,1,2};
            var result = sut.RemoveDuplicates(nums);

            ShowArray(nums);
            Assert.That(result, Is.EqualTo(2));
            Assert.That(nums[1], Is.EqualTo(2));
        }

        [Test]
        public void When122_Returns2()
        {
            var sut = new RemoveDuplicatesFromSortedArray();

            var nums = new int[]{1,2,2};
            var result = sut.RemoveDuplicates(nums);

            ShowArray(nums);
            Assert.That(result, Is.EqualTo(2));
            Assert.That(nums[1], Is.EqualTo(2));
        }

        [Test]
        public void When123_Returns3()
        {
            var sut = new RemoveDuplicatesFromSortedArray();

            var nums = new int[]{1,2,3};
            var result = sut.RemoveDuplicates(nums);

            ShowArray(nums);
            Assert.That(result, Is.EqualTo(3));
            Assert.That(nums[1], Is.EqualTo(2));
            Assert.That(nums[2], Is.EqualTo(3));
        }

        [Test]
        public void When10Elements_Returns5()
        {
            var sut = new RemoveDuplicatesFromSortedArray();

            var nums = new int[]{0,0,1,1,1,2,2,3,3,4};
            var result = sut.RemoveDuplicates(nums);

            ShowArray(nums);
            Assert.That(result, Is.EqualTo(5));
        }

        private void ShowArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
