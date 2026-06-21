# Manual Local Unity Build

This build row is monitor-only. The watcher must not launch Unity.

Run this command manually from `/Users/dragonkao/.openclaw` when Unity license/editor state is ready:

```bash
python3 scripts/run_game_build_pipeline.py --run-id notion-NeonDrift_MVP-build-build-webgl-20260621103121 --project-name NeonDrift_MVP --channel-id 386b9e33-8429-81e9-85b7-ce6e24881102 --stage-range build-webgl --source-output-folder /home/node/.openclaw/workspace/386b9e33-8429-81cf-b934-c921a1167a52/NeonDrift_MVP__development__notion-NeonDrift_MVP-development-dev-full-20260621100917/project/ --source-handoff-path /home/node/.openclaw/workspace/386b9e33-8429-81cf-b934-c921a1167a52/NeonDrift_MVP__development__notion-NeonDrift_MVP-development-dev-full-20260621100917/project/handoffs/development/final_handoff.md --output-folder /home/node/.openclaw/workspace/386b9e33-8429-81e9-85b7-ce6e24881102/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-webgl-20260621103121/project/
```

Optional: add `--unity-path /path/to/Unity` if auto-detection picks the wrong editor.

Expected report: /home/node/.openclaw/workspace/386b9e33-8429-81e9-85b7-ce6e24881102/NeonDrift_MVP__build__notion-NeonDrift_MVP-build-build-webgl-20260621103121/project/status/validation/build_full_validation.md

The build watcher will mark the Notion row finished only after that report exists and contains `- status: passed` or `- status: failed`.
