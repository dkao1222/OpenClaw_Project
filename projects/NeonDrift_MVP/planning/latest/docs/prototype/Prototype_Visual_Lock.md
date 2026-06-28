# Prototype Visual Lock

## 繁體中文

- QA 必須用 simulator screenshots 逐張比對：00_app_launch, 01_main_menu, 02_settings, 03_first_run_tutorial, 04_gameplay_start, 05_normal_gameplay, 06_boost_reward, 07_danger_near_miss, 08_collision_failure, 09_game_over, 10_retry, 11_post_retry_gameplay, 12_pause_resume
- 若實機畫面缺少對應 state、主要 UI、玩家/危險/獎勵語意或 safe-area 合規，不能算 QA Passed。
- Development 不可用未標註的 placeholder 幾何物件替代 visual lock。

## English

- QA must compare simulator screenshots against each frame: 00_app_launch, 01_main_menu, 02_settings, 03_first_run_tutorial, 04_gameplay_start, 05_normal_gameplay, 06_boost_reward, 07_danger_near_miss, 08_collision_failure, 09_game_over, 10_retry, 11_post_retry_gameplay, 12_pause_resume
- If runtime misses the matching state, primary UI, player/danger/reward meaning, or safe-area compliance, QA cannot pass.
- Development may not replace the visual lock with unlabeled placeholder geometry.
