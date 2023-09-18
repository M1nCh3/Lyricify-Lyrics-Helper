﻿using Newtonsoft.Json;

namespace Lyricify.Lyrics.Providers.Web.Kugou
{
    public class Api : BaseApi
    {
        protected override string HttpRefer => "http://kugou.com/"; // 没用，后面都是直接用 Client 发送请求

        public async Task<SearchSongResponse?> GetSearchSong(string keywords)
        {
            var response = await HttpClient.GetStringAsync($"http://mobilecdn.kugou.com/api/v3/search/song?format=json&keyword={keywords}&page=1&pagesize=20&showtype=1");
            var resp = JsonConvert.DeserializeObject<SearchSongResponse>(response);
            return resp;
        }

        public async Task<SearchLyricsResponse?> GetSearchLyrics(string keywords, int? duration = null, string? hash = null)
        {
            string durationPara = string.Empty;
            if (duration != null)
            {
                durationPara = $"&duration={duration}";
            }
            hash ??= string.Empty;
            var response = await HttpClient.GetStringAsync($"https://lyrics.kugou.com/search?ver=1&man=yes&client=pc&keyword={keywords}{durationPara}&hash={hash}");
            var resp = JsonConvert.DeserializeObject<SearchLyricsResponse>(response);
            return resp;
        }
    }
}
