# Lyricify Lyrics Helper

Work hard to build Lyricify lyrics related functions.

## Main functions
- Lyrics parsing
- Lyricify Syllable
- Lyricify Lines
- LRC
- QRC
- KRC
- YRC
- TTML (not supported yet)
- Spotify Lyrics (raw JSON)
- Musixmatch (raw JSON)
- Lyrics generation
- Lyricify Syllable
- Lyricify Lines
- LRC
- QRC
- KRC
- YRC
- Lyrics song search
- QQ Music
- NetEase Cloud Music
- Kugou Music
- Spotify (not supported yet)
- Musixmatch
- Lyrics processing optimization
- Explicit lyrics processing and repair
- YRC lyrics optimization
- Duet recognition (not supported yet)
- Title line recognition (not supported yet)
- Lyrics decryption
- QRC
- KRC
- Embedded general help class
- Chinese help class (conversion between simplified and traditional Chinese, etc.)
- String help class
- Mathematics help class

## Project Architecture
### Lyricify.Lyrics.Helper
- Decrypter // Lyrics decryption related
- Krc
- Qrc
- Generators // Lyrics generation
- Helpers // Helper static class
- General // Embedded general help
- ChineseHelper // Chinese help
- StringHelper // String help
- Optimization // Lyrics processing optimization
- Explicit // Explicit lyrics processing and repair
- Yrc // YRC lyrics optimization
- Musixmatch // Musixmatch lyrics optimization
- Types // Lyrics type
- Lrc // LRC lyrics type characteristics
- GeneratorHelper // Generation help
- OffsetHelper // Offset help (used to add Offset offset to lyrics)
- ParserHelper // Parsing help
- SearchHelper // Search help
- TypeHelper // Lyrics type help
- Models // Lyrics model
- Parsers // Lyrics parsing
- Providers // Lyrics provider
- Web // Provider related interfaces
- Searchers // Song search
- Helpers
- ArtistHelper // Artist help (Chinese and English name comparison of artists)
- CompareHelper // Information matching help
- SearcherHelper // Instantiated search class

### Lyricify.Lyrics.Demo
- Program
- ParsersDemo // Lyrics parsing demo
- GeneratorsDemo // Lyrics generation demo
- TypeDetectorDemo // Lyrics type judgment demo
- SearchDemo // Song search demo

## Thanks and support
Special thanks to [@cnbluefire](https://github.com/cnbluefire), [@Raspberry Kan](https://github.com/Raspberry-Monster) for their help and support.
#### Thanks to the following third-party code
- LyricParser (MIT License): https://github.com/HyPlayer/LyricParser
- 163MusicLyrics (Apache-2.0 License): https://github.com/jitwxs/163MusicLyrics
