using UnityEngine;
using UnityEngine.Video;

public class TestVideoPlayer : MonoBehaviour
{
    [SerializeField] string videoName;
    VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        PlayVideo();
    }

    public void PlayVideo()
    {
        string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoName);
        videoPlayer.url = videoPath;

        videoPlayer.prepareCompleted += OnPrepared;
        videoPlayer.Prepare();
    }

    private void OnPrepared(VideoPlayer vp)
    {
        vp.prepareCompleted -= OnPrepared; // avoid duplicate events
        vp.Play();
    }

}
