using FluentAssertions;
using NUnit.Framework;
using TagsCloudContainer;
using TagsCloudContainer.UI;

namespace TagCloudContainerTests
{
    public class BoringWordsDeleterTests
    {
        [Test]
        public void BoringWordsDeleter_ShouldNotDeleteNotBoringWords()
        {
            var notBoringWords = new[] {"котик", "котенок", "кошка", "кисуля", "котяра"};
            var result = BoringWordsDeleter.DeleteBoringWords(notBoringWords, new ConsoleUiSettings());
            result.Should().BeEquivalentTo(notBoringWords);
        }

        [Test]
        public void BoringWordsDeleter_ShouldDeleteBoringWords()
        {
            var notBoringWords = new[] {"кто", "как", "где", "а", "че"};
            var result = BoringWordsDeleter.DeleteBoringWords(notBoringWords, new ConsoleUiSettings());
            result.Should().BeEmpty();
        }

        [Test]
        public void BoringWordsDeleter_ShouldDeleteEmptyStrings()
        {
            var notBoringWords = new[] {"", "", "", "", "спатеньки"};
            var result = BoringWordsDeleter.DeleteBoringWords(notBoringWords, new ConsoleUiSettings());
            result.Should().BeEquivalentTo("спатеньки");
        }
    }
}